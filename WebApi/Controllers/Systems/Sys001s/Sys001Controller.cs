using AppCore.Application.Systems.Sys001s;
using AppCore.Data.EF;
using AppCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace WebApi.Controllers.Systems.Sys001s
{
    [Route("api/AppUser")]
    [ApiController]
    public class Sys001Controller : ControllerBase
    {
        private readonly ISys001Service _Sys001Service;
        private readonly IUnitOfWork _unitOfWork;

        public Sys001Controller(ISys001Service sys001Service, IUnitOfWork unitOfWork)
        {
            _Sys001Service = sys001Service;
            _unitOfWork = unitOfWork;
        }

        [Route("GetAppUser")]
        [HttpGet]
        public IActionResult GetAppUser()
        {
            try
            {
                var query = _Sys001Service.GetAll();
                return Ok(query);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}