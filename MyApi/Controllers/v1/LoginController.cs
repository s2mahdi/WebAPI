using Common;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyApi.Models;
using Services;
using Services.Emails.MailKits;
using Services.SmsSenders;
using System;
using System.Linq;
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

        public LoginController(IRepository<SmsLoginEvent> repository,
                               IEmailSender emailSender, ISmsSender smsSender,
                               IOptionsSnapshot<SiteSettings> settings,
                               UserManager<User> userManager,
                               IJwtService jwtService,
                               IUserRepository userRepository)
        {
            this.repository = repository;
            this.emailSender = emailSender;
            this.smsSender = smsSender;
            this.siteSettings = settings.Value;
            this.userManager = userManager;
            this.jwtService = jwtService;
            this.userRepository = userRepository;
        }

        #region SMS

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Post([FromBody] SmsLoginDto smsLoginDto, CancellationToken cancellationToken)
        {
            var code = await SaveLoginEvent(smsLoginDto, cancellationToken);

            //send sms
            var sendResult = await smsSender
                .SendAsync(smsLoginDto.MobileNumber.ToString(),
                           code.ToString());

            if (sendResult.IsSuccess)
            {
                return Ok();
            }
            return BadRequest(sendResult.Error);
        }

        private async Task<int> SaveLoginEvent(SmsLoginDto smsLoginDto, CancellationToken cancellationToken)
        {
            int code = new Random().Next(10101, 99999);
            var loginevent = new SmsLoginEvent
            {
                Code = code,
                CreatedDate = DateTime.Now,
                ExpireDate = DateTime.Now.AddMinutes(30),
                IsActive = true,
                MobileNumber = smsLoginDto.MobileNumber,
                IsValidate = false
            };
            await repository.AddAsync(loginevent, cancellationToken);
            return code;
        }


        [HttpPut("Verify")]
        [AllowAnonymous]
        public async Task<ActionResult> Verify([FromBody] VerifySmsLoginDto verifyDto, CancellationToken cancellationToken)
        {

            var date = DateTime.Now;
            var loginEvent = await repository.Entities
                .Where(c =>
                        c.IsActive &&
                        c.Code == verifyDto.Code &&
                        c.MobileNumber == verifyDto.MobileNumber &&
                        c.ExpireDate > date).FirstOrDefaultAsync(cancellationToken);

            if (loginEvent == null)
            {
                return BadRequest();
            }

            await CheckPhoneNumber(verifyDto, cancellationToken);

            //send token
            var user = await userRepository.Table
                .Where(c => c.PhoneNumber == verifyDto.MobileNumber.ToString())
                .FirstAsync(cancellationToken);

            var jwt = await jwtService.GenerateAsync(user);

            user.PhoneNumberConfirmed = true;
            userRepository.Update(user);

            loginEvent.IsActive = false;
            repository.Update(loginEvent);
            return Ok(jwt);
        }
        private async Task CheckPhoneNumber(VerifySmsLoginDto smsLoginDto, CancellationToken cancellationToken)
        {
            User user = await userRepository.TableNoTracking.FirstOrDefaultAsync(c => c.PhoneNumber == smsLoginDto.MobileNumber);
            if (user == null)
            {
                var result = await userManager.CreateAsync(new User()
                {
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
            var user =await userRepository.TableNoTracking
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
            await userRepository.UpdateAsync(user,cancellationToken);
            return Ok();
        }
        #endregion
    }
}
