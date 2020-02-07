using AppCore.Application.Systems.Sys001s;
using AppCore.Data.Entities.System;
using AppCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers.Systems.Sys001s
{
    [Route("Api/AppUser")]
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

        //[Route("ChangePassword")]
        //[HttpPost]
        //public IActionResult ChangePassword([FromBody] ChangePassWord Pass)
        //{
        //    //try
        //    //{
        //    //    using (var FluxDB = new IdentityFluxDB())
        //    //    {
        //    //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //    //        string password = helper.Encrypt("T", Pass.passwordOld);
        //    //        var user = FluxDB.User.FirstOrDefault(x => x.UserID.ToString().Contains(Pass.IdUser) && x.Password.Contains(password));
        //    //        if (user != null)
        //    //        {
        //    //            string pwnew = helper.Encrypt("T", Pass.PasswordNew);
        //    //            user.Password = pwnew;
        //    //            FluxDB.SaveChanges();
        //    //            response.Content = new StringContent(JsonConvert.SerializeObject(new
        //    //            {
        //    //                messageBox = "Thành Công!"
        //    //            }));
        //    //            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    //            return response;
        //    //        }
        //    //        else
        //    //        {
        //    //            response.Content = new StringContent(JsonConvert.SerializeObject(new
        //    //            {
        //    //                messageBox = "Thất Bại!"
        //    //            }));
        //    //            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    //            return response;
        //    //        }

        //    //    }

        //    //}
        //    //catch
        //    //{
        //    //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    //}
        //}
        //[Route("ResetPassword/{userid}")]
        //[HttpGet]
        //public IActionResult ResetPassword(string userid)
        //{
        //    //try
        //    //{
        //    //    using (var FluxDB = new IdentityFluxDB())
        //    //    {
        //    //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //    //        var user = FluxDB.User.FirstOrDefault(x => x.UserID.ToString().Contains(userid));
        //    //        if (user != null)
        //    //        {
        //    //            string pwnew = helper.Encrypt("T", "123456");
        //    //            user.Password = pwnew;
        //    //            FluxDB.SaveChanges();
        //    //            response.Content = new StringContent(JsonConvert.SerializeObject(new
        //    //            {
        //    //                messageBox = "Thành Công!"
        //    //            }));
        //    //            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    //            return response;
        //    //        }
        //    //        else
        //    //        {
        //    //            response.Content = new StringContent(JsonConvert.SerializeObject(new
        //    //            {
        //    //                messageBox = "Thất Bại!"
        //    //            }));
        //    //            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        //    //            return response;
        //    //        }

        //    //    }

        //    //}
        //    //catch
        //    //{
        //    //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    //}
        //}
        [HttpPost]
        public IActionResult Create(Sys001 user)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                try
                {
                    _Sys001Service.Add(user);
                    _Sys001Service.Save();
                    return Ok();
                }
                catch (ValidationException ex)
                {
                    return BadRequest(ex.InnerException);
                }
                catch (DbUpdateException ex)
                {
                    return BadRequest(ex.InnerException);
                }
            }
        }

        //[HttpPut]
        //public IActionResult Update(Sys001 user)
        //{
        //    //try
        //    //{
        //    //    using (var FluxDB = new IdentityFluxDB())
        //    //    {
        //    //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //    //        var data = FluxDB.User.SingleOrDefault(p => p.UserID == user.UserID);
        //    //        data.Manhanvien = user.Manhanvien;
        //    //        data.Hovaten = user.Hovaten;
        //    //        data.Email = user.Email;
        //    //        data.Sodienthoai = user.Sodienthoai;
        //    //        data.Username = user.Username;
        //    //        // data.Password = user.Password;
        //    //        data.Anhdaidien = user.Anhdaidien;
        //    //        data.Diachi = user.Diachi;
        //    //        data.Ngaysinh = user.Ngaysinh;
        //    //        data.Tinhtrang = user.Tinhtrang;
        //    //        data.CMTND = user.CMTND;
        //    //        data.Ngayvao = user.Ngayvao;
        //    //        data.Ngaycapnhap = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        //    //        data.Kieuuser = user.Kieuuser;
        //    //        data.Chucvu = user.Chucvu;
        //    //        data.Capbac = user.Capbac;
        //    //        FluxDB.SaveChanges();
        //    //        return response;
        //    //    }
        //    //}
        //    //catch
        //    //{
        //    //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    //}
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //public IActionResult Delete(Guid id)
        //{
        //    //try
        //    //{
        //    //    using (var FluxDB = new IdentityFluxDB())
        //    //    {
        //    //        var response = new HttpResponseMessage(HttpStatusCode.OK);
        //    //        var data = FluxDB.User.SingleOrDefault(p => p.UserID == id);
        //    //        FluxDB.User.Remove(data);
        //    //        FluxDB.SaveChanges();
        //    //        return response;
        //    //    }
        //    //}
        //    //catch
        //    //{
        //    //    return new HttpResponseMessage(HttpStatusCode.BadRequest);
        //    //}
        //}
    }
}