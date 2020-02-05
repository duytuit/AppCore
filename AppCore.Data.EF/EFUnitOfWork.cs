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
            this._appDbContext = appDbContext;
        }

        public async Task Commit()
        {
            await this._appDbContext.SaveChangesAsync();
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
            this._appDbContext.Dispose();
        }
    }
}
