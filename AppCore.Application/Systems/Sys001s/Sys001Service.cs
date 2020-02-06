using AppCore.Application.Helpers;
using AppCore.Application.Systems.Sys001s.Dtos;
using AppCore.Data.EF;
using AppCore.Data.Entities.System;
using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.Interfaces;
using AppCore.Utilities.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Application.Systems.Sys001s
{
    public class Sys001Service : WebServiceBase<Sys001, Guid>, ISys001Service
    {
        private readonly IRepository<Sys001, Guid> _Sys001Repository;
        private readonly IUnitOfWork _unitOfWork;
        public Sys001Service(IRepository<Sys001, Guid> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _Sys001Repository = repository;
            _unitOfWork = unitOfWork;
        }
        public override void Add(Sys001 sys001)
        {
            string depass = helper.Encrypt("T", sys001.Password);
            var data = new Sys001()
            {
                //Id=Guid.NewGuid(),
                Manhanvien = sys001.Manhanvien,
                Hovaten = sys001.Hovaten,
                Email = sys001.Email,
                Sodienthoai = sys001.Sodienthoai,
                Username = sys001.Username,
                Password = depass,
                Anhdaidien = sys001.Anhdaidien,
                Diachi = sys001.Diachi,
                Ngaysinh = DateTime.Now.Date,
                Trangthai = sys001.Trangthai,
                CMTND = sys001.CMTND,
                Ngaytao = DateTime.Now,
                Kieuuser = sys001.Kieuuser,
                Chucvu = sys001.Chucvu,
                Capbac = sys001.Capbac
            };
            _Sys001Repository.Insert(data);
        }
    }
}
