using AppCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public EFUnitOfWork(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public async Task Commit()
        {
            await this._appDbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this._appDbContext.Dispose();
        }
    }
}
