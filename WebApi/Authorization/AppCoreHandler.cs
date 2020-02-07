using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Authorization
{
    public class AppCoreHandler : AuthorizationHandler<AppCoreRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AppCoreRequirement requirement)
        {
          //  var userEmailAddress = context.User?.FindFirstValue(ClaimTypes.Email) ?? string.Empty;
            //if (userEmailAddress.EndsWith(requirement.DomainName))
            //{
            //    context.Succeed(requirement);
            //    return Task.CompletedTask;
            //}

            context.Fail();
            return Task.CompletedTask;
        }
    }
}
