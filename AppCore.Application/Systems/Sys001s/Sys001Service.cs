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
        //public void Dispose()
        //{
        //    GC.SuppressFinalize(this);
        //}
    }
}
