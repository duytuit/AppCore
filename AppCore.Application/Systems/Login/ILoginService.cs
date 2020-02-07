
using AppCore.Application.Systems.Login.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Application.Systems.Login
{
    public interface ILoginService
    {
        Task<AuthenticationResult> RegisterAsync(string user, string password);

        Task<AuthenticationResult> LoginAsync(string user, string password);

        Task<AuthenticationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}
