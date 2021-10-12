using Common;
using Common.Exceptions;
using Common.Utilities;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using MyApi.Models;
using Services;
using Services.Emails.MailKits;
using Services.SmsSenders;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    [ApiVersion("1")]
    public class LoginController : BaseController
    {
        private readonly IRepository<SmsLoginEvent> repository;
        private readonly IEmailSender emailSender;
        private readonly ISmsSender smsSender;
        private readonly SiteSettings siteSettings;
        private readonly UserManager<User> userManager;
        private readonly IJwtService jwtService;
        private readonly IUserRepository userRepository;
        private readonly IRepository<CompanyUserMobile> companyMobileRepository;
        private readonly IRepository<MobileActivation> mobileActivationRepository;

        public LoginController(IRepository<SmsLoginEvent> repository,
                               IEmailSender emailSender, ISmsSender smsSender,
                               IOptionsSnapshot<SiteSettings> settings,
                               UserManager<User> userManager,
                               IJwtService jwtService,
                               IUserRepository userRepository,
                               IRepository<CompanyUserMobile> companyMobileRepository,
                               IRepository<MobileActivation> mobileActivationRepository)
        {
            this.repository = repository;
            this.emailSender = emailSender;
            this.smsSender = smsSender;
            this.siteSettings = settings.Value;
            this.userManager = userManager;
            this.jwtService = jwtService;
            this.userRepository = userRepository;
            this.companyMobileRepository = companyMobileRepository;
            this.mobileActivationRepository = mobileActivationRepository;
        }


        #region SMS

        [AllowAnonymous]
        [HttpGet("VerifySMS")]
        public async Task<int> VerifySMS(string mobileNumber, CancellationToken cancellationToken)
        {
            var mobilePattern = @"^09[0|1|2|3][0-9]{8}$";
            var match = Regex.Match(mobileNumber, mobilePattern);

            if (match.Success)
            {
                //Obtain user mobile
                var companyUserMobile = await companyMobileRepository.Entities.Where(p => p.Mobile == mobileNumber).SingleOrDefaultAsync();

                // Check the mobile number that user send is exist and the expire date is valid
                if (companyUserMobile != null)
                {
                    if (companyUserMobile.ExpireDateAccess >= DateTime.Now && companyUserMobile.IsActive != false)
                    {
                        var verificationCode = await SaveLoginEvent(mobileNumber, cancellationToken);

                        //send sms --> Uncomment this section, after the SMS service has established and change the return type to 'ActionResult'
                        //var sendResult = await smsSender.SendAsync(mobileNumber.ToString(), verificationCode.ToString());

                        //if (sendResult.IsSuccess)
                        //{
                        //    return Ok();
                        //}
                        //return BadRequest(sendResult.Error);

                        return verificationCode;
                    }
                    else
                    {
                        throw new BadRequestException("شماره موبایل شما غیر فعال است ");
                    }

                }
                else
                {
                    throw new BadRequestException("شماره موبایل در سیستم یافت نشد");
                }

            }
            else
            {
                throw new BadRequestException("شماره همراه وارد شده صحیح نمی باشد");
            }
        }

        [AllowAnonymous]
        [HttpPut("ConfirmUser")]
        public async Task<ActionResult> ConfirmSMS(VerifySmsLoginDto verifyDto, CancellationToken cancellationToken)
        {
            var date = DateTime.Now;
            var loginEvent = await mobileActivationRepository.Entities
                .Where(c =>
                        c.ActivationCode == verifyDto.Code.ToString() &&
                        c.Mobile == verifyDto.MobileNumber &&
                        c.ExpireDate > date).FirstOrDefaultAsync(cancellationToken);


            if (loginEvent == null)
            {
                return BadRequest();
            }

            await CheckPhoneNumber(verifyDto, cancellationToken);

            //send token
            var user = await userRepository.Table
                .Where(c => c.Mobile == verifyDto.MobileNumber)
                .FirstAsync(cancellationToken);

            var jwt = await jwtService.GenerateAsync(user);

            user.PhoneNumberConfirmed = true;
            userRepository.Update(user);

            var query = await mobileActivationRepository.Entities.Where(p => p.Id == loginEvent.Id).SingleOrDefaultAsync();

            query.Status = (int)EnumStatus.VerificationStatus.AcceptUser;
            mobileActivationRepository.Update(query);

            //Check the ExpireDate is valid
            if (loginEvent.ExpireDate < date)
            {
                query.Status = (int)EnumStatus.VerificationStatus.ExpireTime;
                mobileActivationRepository.Update(query);
                return new BadRequestResult();
            }

            //check the verification code is correct or not
            if (loginEvent.ActivationCode != verifyDto.Code.ToString())
            {
                query.Status = (int)EnumStatus.VerificationStatus.NotCorrectCode;
                mobileActivationRepository.Update(query);
                return new BadRequestResult();
            }

            return Ok(jwt);

        }

        [AllowAnonymous]
        [HttpPut("CheckSMSMethod")]
        public async Task<ActionResult> CheckSMSMethod(string mobileNumber, int code, CancellationToken cancellationToken)
        {
            var date = DateTime.Now;
            var loginEvent = await mobileActivationRepository.Entities
                .Where(c =>
                        c.ActivationCode == code.ToString() &&
                        c.Mobile == mobileNumber &&
                        c.ExpireDate > date).FirstOrDefaultAsync(cancellationToken);


            if (loginEvent == null)
            {
                return BadRequest();
            }

            //await CheckPhoneNumber(verifyDto, cancellationToken);

            //send token
            var user = await userRepository.Table
                .Where(c => c.Mobile == mobileNumber)
                .FirstAsync(cancellationToken);

            var jwt = await jwtService.GenerateAsync(user);

            user.PhoneNumberConfirmed = true;
            userRepository.Update(user);

            var query = await mobileActivationRepository.Entities.Where(p => p.Id == loginEvent.Id).SingleOrDefaultAsync();

            query.Status = (int)EnumStatus.VerificationStatus.AcceptUser;
            mobileActivationRepository.Update(query);

            //Check the ExpireDate is valid
            if (loginEvent.ExpireDate < date)
            {
                query.Status = (int)EnumStatus.VerificationStatus.ExpireTime;
                mobileActivationRepository.Update(query);
                return new BadRequestResult();
            }

            //check the verification code is correct or not
            if (loginEvent.ActivationCode != code.ToString())
            {
                query.Status = (int)EnumStatus.VerificationStatus.NotCorrectCode;
                mobileActivationRepository.Update(query);
                return new BadRequestResult();
            }

            return Ok(jwt);
        }

        private async Task<int> SaveLoginEvent(string mobileNumber, CancellationToken cancellationToken)
        {
            int verificationCode = new Random().Next(10101, 99999);

            var mobilActivation = new MobileActivation
            {
                ActivationCode = verificationCode.ToString(),
                Mobile = mobileNumber,
                Status = (byte)EnumStatus.VerificationStatus.SendSMS,
                StatusDate = DateTime.Now,
                CreateTime = DateTime.Now,
                ExpireDate = DateTime.Now.AddMinutes(5)
            };

            await mobileActivationRepository.AddAsync(mobilActivation, cancellationToken);
            return verificationCode;
        }

        private async Task CheckPhoneNumber(VerifySmsLoginDto smsLoginDto, CancellationToken cancellationToken)
        {
            User user = await userRepository.TableNoTracking.FirstOrDefaultAsync(c => c.PhoneNumber == smsLoginDto.MobileNumber);
            if (user == null)
            {
                var result = await userManager.CreateAsync(new User()
                {
                    FirstName = "جلال",
                    LastName = "مصطفی نیا",
                    PhoneNumber = smsLoginDto.MobileNumber.ToString(),
                    UserName = smsLoginDto.MobileNumber.ToString(),
                    IsActive = true,
                    Gender = GenderType.Unknown,
                    Email = Guid.NewGuid() + "@test.test",
                    Mobile = smsLoginDto.MobileNumber.ToString(),
                    EmailVerifyer = Guid.NewGuid()
                }, "123456");
            }
        }

        #endregion

        #region Email
        [HttpPut]
        [AllowAnonymous]
        [Route("VerifyEmail")]
        public async Task<ActionResult> VerifyEmail([FromBody] ConfirmEmailDto confirmEmailDto, CancellationToken cancellationToken)
        {
            var user = await userRepository.TableNoTracking
                .Where(c => c.Email == confirmEmailDto.Email && c.EmailConfirmed == false)
                .FirstOrDefaultAsync(cancellationToken);

            if (user == null) return NotFound();

            var confirmToken = user.EmailVerifyer;
            var confirmationLink = Url.Action(nameof(ConfirmEmail), "Login", new { token = confirmToken }, Request.Scheme);
            await emailSender.SendEmail(new EmailMessage("lotfi.engin@gmail.com", siteSettings.EmailSetting.Subject, confirmationLink));
            return Ok();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("ConfirmEmail")]
        public async Task<ActionResult> ConfirmEmail(Guid token, CancellationToken cancellationToken)
        {
            var user = await userManager.Users.AsNoTracking()
                .FirstOrDefaultAsync(c => c.EmailVerifyer.Equals(token) && c.EmailConfirmed == false);

            if (user == null) return BadRequest("Invalid Token");

            user.EmailVerifyer = Guid.NewGuid();
            user.EmailConfirmed = true;
            await userRepository.UpdateAsync(user, cancellationToken);
            return Ok();
        }
        #endregion
    }
}
