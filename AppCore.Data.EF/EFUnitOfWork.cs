using AppCore.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = _appDbContext.Database.BeginTransaction();
        }
        public EFUnitOfWork(AppDbContext appDbContext)
        {
           _appDbContext = appDbContext;
        }

        public void Commit()
        {
              _appDbContext.SaveChanges();
        }
        public void TransactionCommit()
        {
            _transaction.Commit();
        }
        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
