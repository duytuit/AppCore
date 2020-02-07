using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Authorization
{
    public class AppCoreRequirement : IAuthorizationRequirement
    {
        public string DomainName { get; }

        public AppCoreRequirement(string domainName)
        {
            DomainName = domainName;
        }
    }
}
