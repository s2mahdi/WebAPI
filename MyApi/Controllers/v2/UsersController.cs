using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApi.Models;
using Services;
using WebFramework.Api;

namespace MyApi.Controllers.v2
{
    [ApiVersion("2")]
    public class UsersController : v1.UsersController
    {
        private readonly IUserRepository userRepository;

        public UsersController(IUserRepository userRepository,
            ILogger<v1.UsersController> logger,
            IJwtService jwtService,
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            SignInManager<User> signInManager)
            : base(userRepository, logger, jwtService, userManager, roleManager, signInManager)
        {
            this.userRepository = userRepository;
        }

        public override Task<ApiResult<User>> Create(UserDto userDto, CancellationToken cancellationToken)
        {
            return base.Create(userDto, cancellationToken);
        }

        public override Task<ApiResult> Delete(int id, CancellationToken cancellationToken)
        {
            return base.Delete(id, cancellationToken);
        }

        public override Task<ActionResult<List<User>>> Get(CancellationToken cancellationToken)
        {
            return base.Get(cancellationToken);
        }

        public override Task<ApiResult<User>> Get(int id, CancellationToken cancellationToken)
        {
            return base.Get(id, cancellationToken);
        }

        public override Task<ActionResult> Token([FromForm] TokenRequest tokenRequest, CancellationToken cancellationToken)
        {
            return base.Token(tokenRequest, cancellationToken);
        }

        public override Task<ApiResult> Update(int id, User user, CancellationToken cancellationToken)
        {
            return base.Update(id, user, cancellationToken);
        }

        [HttpPut("EditProfile/{id:int}")]
        public virtual async Task<ApiResult> EditProfile(int id, [FromBody] UserProfileDto userProfile, CancellationToken cancellationToken)
        {
            var updateUser = await userRepository.GetByIdAsync(cancellationToken, id);

            updateUser.Address = userProfile.Address;
            updateUser.Education = userProfile.Education;
            updateUser.FirstName = userProfile.FirstName;
            updateUser.LastName = userProfile.LastName;
            updateUser.BirthDate = userProfile.BirthDate;
            updateUser.Email = userProfile.Email;
            updateUser.FCustomeName = userProfile.FCustomeName;
            updateUser.Position = userProfile.Position;
            updateUser.UnitName = userProfile.UnitName;

            await userRepository.UpdateAsync(updateUser, cancellationToken);

            return Ok();
        }

        [Route("ConfirmProfile/{id:int}")]
        [HttpPut]
        public virtual async Task<ApiResult> ConfirmProfile(int id, CancellationToken cancellationToken)
        {
            var updateUser = await userRepository.GetByIdAsync(cancellationToken, id);

            updateUser.IsActive = true;
            updateUser.IsProfileCompleted = true;

            await userRepository.UpdateAsync(updateUser, cancellationToken);

            return Ok();
        }

        [HttpGet("asdasd")]
        public ApiResult<List<Claim>> Test2()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Ok(User.Claims.ToList());
            }
            else
            {
                return new ApiResult<List<Claim>>(false, Common.ApiResultStatusCode.UnAuthorized, null);
            }
        }
    }
}
