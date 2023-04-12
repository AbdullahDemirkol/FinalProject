using IdentityCheckServiceApi.Business.Abstract;
using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Business.Concrete
{
    public class IdentityManager : IIdentityService
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private IdentityCheckContext _identityCheckContext;

        public IdentityManager(IConfiguration configuration, IdentityCheckContext identityCheckContext)
        {
            _identityCheckContext = identityCheckContext ?? throw new ArgumentNullException(nameof(identityCheckContext));
            _tokenOptions = configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
        }

        public Task<LoginResponseModel> Login(LoginRequestModel loginRequestModel)
        {
            var user = CheckLogin(loginRequestModel);

            if (user == null)
            {
                LoginResponseModel nullLoginResponseModel = new() { };
                return Task.FromResult(nullLoginResponseModel);
            }
            var claims = SetClaims(user, loginRequestModel);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var jwtToken = CreateJwtSecurityToken(_tokenOptions, claims, accessTokenExpiration, creds);

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            LoginResponseModel loginResponseModel = new()
            {
                UserToken = encodedJwt,
                Username = user.Username,
                RoleName= user.Role.Name,
                Expiration = accessTokenExpiration

            };
            return Task.FromResult(loginResponseModel);

        }
        private List<Claim> SetClaims(UserModel user, LoginRequestModel loginRequestModel)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(type: ClaimTypes.NameIdentifier, value: loginRequestModel.UserName));
            claims.Add(new Claim(type: ClaimTypes.Name, value: user.FirstName + " " + user.LastName));
            claims.Add(new Claim(type: ClaimTypes.Email, value: user.Email));
            claims.Add(new Claim(type: ClaimTypes.MobilePhone, value: user.Phone));
            claims.Add(new Claim(type: ClaimTypes.Role, value: user.Role.Name));
            return claims;
        }
        private JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, List<Claim> claims, DateTime accessTokenExpiration, SigningCredentials creds)
        {
            var token = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                claims: claims,
                expires: accessTokenExpiration,
                signingCredentials: creds,
                notBefore: DateTime.Now);
            return token;

        }
        private UserModel CheckLogin(LoginRequestModel loginRequestModel)
        {
            var hashedPassword = HashingHelper.SHA512(loginRequestModel.Password);
            var user = _identityCheckContext.Users.Include(p=>p.Role).FirstOrDefault(p => p.Password == hashedPassword && p.Username == loginRequestModel.UserName && p.Status == true);

            return user != null ? user : null;

        }

        public async Task<string> Register(UserModel user)
        {
            user.Phone = String.Format("{0:(000) 000 00 00}", Convert.ToInt64(user.Phone));
            var registeredUser = CheckİnformationFromDatabase(user);
            if (registeredUser)
            {
                return await Task.FromResult("Bu bilgilere ait kullanıcı bulunmakta veya bilgiler hatalı verilmiş.");
            }

            user.Password = HashingHelper.SHA512(user.Password);
            user.Status = true;
            _identityCheckContext.Users.Add(user);
            await _identityCheckContext.SaveChangesAsync();

            return await Task.FromResult("Kayıt işlemi başarılı bir şekilde gerçekleştirildi.");
        }

        private bool CheckİnformationFromDatabase(UserModel user)
        {
            var registeredUser = _identityCheckContext.Users.
                Any(p => (p.Username == user.Username || p.Email == user.Email || p.Phone == user.Phone) && p.Status == true);
            return registeredUser;
        }

    }
}
