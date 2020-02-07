﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppcoreapiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("AppCoreAPI");
        }
    }
}