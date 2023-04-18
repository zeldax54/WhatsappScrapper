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
    public class AdminRoleRequirement : IAuthorizationRequirement
    {      
        public AdminRoleRequirement() 
        {            
        }
    }

    public class AdminRoleRequirementHandler : AuthorizationHandler<AdminRoleRequirement>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IIdentityConsumer _identityConsumer;
        public AdminRoleRequirementHandler(IHttpContextAccessor httpContextAccessor, IIdentityConsumer identityConsumer)
        {
            _httpContextAccessor = httpContextAccessor;
            _identityConsumer = identityConsumer;
        }
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, AdminRoleRequirement requirement)
        {
            HttpContext httpContext = _httpContextAccessor.HttpContext;

            string? accessToken = httpContext.Request.Headers["Authorization"].
            ToString()?.Replace("Bearer ", "");
            var tokenRequest = new TokenRequest()
            {
                Role = "Admin",
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
