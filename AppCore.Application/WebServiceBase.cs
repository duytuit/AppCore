using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.Interfaces;
using AppCore.Infrastructure.SharesKernel;
using AppCore.Utilities.Dtos;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AppCore.Application
{
    /// <summary>
    /// Base webserice for all services
    /// Creator: Toanbn
    /// Created Date: May 10, 2018
    /// </summary>
    /// <typeparam name="TEntity">Main entity for WS</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type for main entity</typeparam>
    /// <typeparam name="ViewModel">View Model class</typeparam>
    public abstract class WebServiceBase<TEntity, TPrimaryKey> : IWebServiceBase<TEntity, TPrimaryKey> where TEntity : DomainEntity<TPrimaryKey>
    {
        private readonly IRepository<TEntity, TPrimaryKey> _repository;
        private readonly IUnitOfWork _unitOfWork;

        protected WebServiceBase(IRepository<TEntity, TPrimaryKey> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual void Add(TEntity entity)
        {
            _repository.Insert(entity);
        }

        public virtual void Delete(TPrimaryKey id)
        {
            _repository.Delete(id);
        }

        public virtual List<TEntity> GetAll()
        {
            return _repository.GetAllList();
        }

        public PaginationResult<TEntity> GetAllPaging(Expression<Func<TEntity, bool>> predicate, Func<TEntity, bool> orderBy, SortDirection sortDirection, int pageIndex, int pageSize)
        {
            var query = _repository.GetAll().Where(predicate);

            int totalRow = query.Count();

            if (sortDirection == SortDirection.Ascending)
            {
                query = query.OrderBy(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }
            else
            {
                query = query.OrderByDescending(orderBy).Skip((pageIndex - 1) * pageSize).Take(pageSize).AsQueryable();
            }

            var data = query.ToList();
            var paginationSet = new PaginationResult<TEntity>()
            {
                Results = data,
                CurrentPage = pageIndex,
                RowCount = totalRow,
                PageSize = pageSize
            };

            return paginationSet;
        }

        public virtual TEntity GetById(TPrimaryKey id)
        {
            return _repository.GetById(id);
        }

        public virtual void Save()
        {
            _unitOfWork.Commit();
        }

        public virtual void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
