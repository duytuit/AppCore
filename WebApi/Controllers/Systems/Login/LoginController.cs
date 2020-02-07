using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AppCore.Data.EF;
using AppCore.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApi.Helpers;

namespace WebApi.Controllers.Systems.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _appDbContext;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly AppSettings _appSettings;

        public LoginController(IUnitOfWork unitOfWork, AppDbContext appDbContext, TokenValidationParameters tokenValidationParameters, AppSettings appSettings)
        {
            _unitOfWork = unitOfWork;
            _appDbContext = appDbContext;
            _tokenValidationParameters = tokenValidationParameters;
            _appSettings = appSettings;
        }

        private ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationParameters = _tokenValidationParameters.Clone();
                tokenValidationParameters.ValidateLifetime = false;
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);
                if (!IsJwtWithValidSecurityAlgorithm(validatedToken))
                {
                    return null;
                }

                return principal;
            }
            catch
            {
                return null;
            }
        }

        private bool IsJwtWithValidSecurityAlgorithm(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) &&
                   jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                       StringComparison.InvariantCultureIgnoreCase);
        }

        //private async Task<AuthenticationResult> GenerateAuthenticationResultForUserAsync(IdentityUser user)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

        //    var claims = new List<Claim>
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub, user.Email),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        new Claim(JwtRegisteredClaimNames.Email, user.Email),
        //        new Claim("id", user.Id)
        //    };

        //    var userClaims = await _userManager.GetClaimsAsync(user);
        //    claims.AddRange(userClaims);

        //    var userRoles = await _userManager.GetRolesAsync(user);
        //    foreach (var userRole in userRoles)
        //    {
        //        claims.Add(new Claim(ClaimTypes.Role, userRole));
        //        var role = await _roleManager.FindByNameAsync(userRole);
        //        if (role == null) continue;
        //        var roleClaims = await _roleManager.GetClaimsAsync(role);

        //        foreach (var roleClaim in roleClaims)
        //        {
        //            if (claims.Contains(roleClaim))
        //                continue;

        //            claims.Add(roleClaim);
        //        }
        //    }

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(claims),
        //        Expires = DateTime.UtcNow.Add(_appSettings.TokenLifetime),
        //        SigningCredentials =
        //            new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);

        //    var refreshToken = new RefreshToken
        //    {
        //        JwtId = token.Id,
        //        UserId = user.Id,
        //        CreationDate = DateTime.UtcNow,
        //        ExpiryDate = DateTime.UtcNow.AddMonths(6)
        //    };

        //    //await _appDbContext.RefreshTokens.AddAsync(refreshToken);
        //     _unitOfWork.Commit();

        //    return new AuthenticationResult
        //    {
        //        Success = true,
        //        Token = tokenHandler.WriteToken(token),
        //        RefreshToken = refreshToken.Token
        //    };
        //}
    }
}