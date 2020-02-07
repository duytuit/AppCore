using AppCore.Application.Systems.Login.Dtos;
using AppCore.Data.EF;
using AppCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Application.Systems.Login
{
    public class LoginService : ILoginService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _appDbContext;

        public LoginService(IUnitOfWork unitOfWork, AppDbContext appDbContext)
        {
            _unitOfWork = unitOfWork;
            _appDbContext = appDbContext;
        }

        public Task<AuthenticationResult> LoginAsync(string user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticationResult> RegisterAsync(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
