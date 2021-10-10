using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;

namespace Common.Users
{
    public class WebUserInfoService : IUserInfoService
    {
        private readonly HttpContext _httpContext;


        public WebUserInfoService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }


        public int UserId()
        {
            try
            {
                var claim = _httpContext.User?.GetClaim(ClaimTypes.NameIdentifier);

                if (int.TryParse(claim, out int id))
                {
                    return id;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}