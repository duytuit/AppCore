using AppCore.Infrastructure.Enums;
using AppCore.Infrastructure.SharesKernel;
using AppCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AppCore.Application
{
    public interface IWebServiceBase<TEntity, TPrimaryKey> 
        where TEntity : DomainEntity<TPrimaryKey>
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TPrimaryKey id);

        TEntity GetById(TPrimaryKey id);

        List<TEntity> GetAll();

        PaginationResult<TEntity> GetAllPaging(Expression<Func<TEntity, bool>> predicate, Func<TEntity, bool> orderBy,
            SortDirection sortDirection, int pageIndex, int pageSize);

        void Save();
    }
}
