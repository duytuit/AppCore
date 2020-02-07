﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Helpers
{
    public class RefreshToken
    {
        public string Token { get; set; }

        public string JwtId { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool Used { get; set; }

        public bool Invalidated { get; set; }

        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }
}
