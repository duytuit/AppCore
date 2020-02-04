using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AppCore.Application.Systems.Sys001s;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApi.Controllers.Systems.Sys001s
{
    [Route("api/AppUser")]
    [ApiController]
    public class Sys001Controller : ControllerBase
    {
        private readonly ISys001Service _Sys001Service;

        public Sys001Controller(ISys001Service sys001Service)
        {
            _Sys001Service = sys001Service;
        }
        [Route("GetAppUser")]
        [HttpGet]
        public HttpResponseMessage GetAppUser()
        {
            try
            {
               
                    var response = new HttpResponseMessage(HttpStatusCode.OK);

                    var query = _Sys001Service.GetAll();
                    response.Content = new StringContent(JsonConvert.SerializeObject(query));
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    return response;
             

            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}