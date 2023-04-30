using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Whatsapp.ApiConsumer.Identity;
using WhatsAppScrapper.Models.Refit;

namespace Whatsapp.Identity
{
    public class UserRoleRequirement : IAuthorizationRequirement
    {
        public UserRoleRequirement()
        {
        }
    }

    public class UserRoleRequirementHandler : AuthorizationHandler<UserRoleRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IIdentityConsumer _identityConsumer;
        public UserRoleRequirementHandler(IHttpContextAccessor httpContextAccessor, IIdentityConsumer identityConsumer)
        {
            _httpContextAccessor = httpContextAccessor;
            _identityConsumer = identityConsumer;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, UserRoleRequirement requirement)
        {
            HttpContext httpContext = _httpContextAccessor.HttpContext;

            string? accessToken = httpContext.Request.Headers["Authorization"].
            ToString()?.Replace("Bearer ", "");
            var tokenRequest = new TokenRequest()
            {
                Role = "User",
                Token = accessToken
            };
            var result = await _identityConsumer.Tokenvalidate(tokenRequest);

            if (result.Data == true)
                context.Succeed(requirement);
            else
                context.Fail();

            return;
        }


    }
}
