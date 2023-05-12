using IdentityCheckServiceApi.Business.Abstract;
using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Entity.Concrete.Helper;
using IdentityCheckServiceApi.Utilities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<string> Register(UserModel user,string roleName)
        {
            try
            {

                user.Phone = String.Format("{0:(000) 000 00 00}", Convert.ToInt64(user.Phone));
                var registeredUser = CheckİnformationFromDatabase(user);
                if (registeredUser)
                {
                    return await Task.FromResult("Bu bilgilere ait kullanıcı bulunmakta veya bilgiler hatalı verilmiş.");
                }
                user.Role = _identityCheckContext.Roles.FirstOrDefault(p => p.Name == roleName);
                user.Password = HashingHelper.SHA512(user.Password);
                user.Status = true;
                _identityCheckContext.Users.Add(user);
                _identityCheckContext.SaveChanges();
            }
            catch (Exception e)
            {
                var x = e.Message;
            }

            return await Task.FromResult("Kayıt işlemi başarılı bir şekilde gerçekleştirildi.");
        }
        private bool CheckİnformationFromDatabase(UserModel user)
        {
            var registeredUser = _identityCheckContext.Users.
                Any(p => (p.Username == user.Username || p.Email == user.Email || p.Phone == user.Phone) && p.Status == true);
            return registeredUser;
        }

        public async Task<PaginatedViewModel<UserModel>> GetUsers(int pageSize,int pageIndex, Expression<Func<UserModel, bool>> filter = null, Func<IQueryable<UserModel>, IOrderedQueryable<UserModel>> orderBy = null)
        {
            IQueryable<UserModel> users = _identityCheckContext.Users.Include(p => p.Role);

            if (filter != null)
            {
                users = users.Where(filter);
            }
            if (orderBy != null)
            {
                users = orderBy(users);
            }

            List<UserModel> userList = await users.ToListAsync();
            int userListCount = userList.Count();
            userList = userList.Skip(pageSize * pageIndex).Take(pageSize).ToList();
            PaginatedViewModel<UserModel> model = new PaginatedViewModel<UserModel>(pageIndex,pageSize,userListCount,userList);
            return model;
        }

        private UserModel Get(Expression<Func<UserModel, bool>> filter, params Expression<Func<UserModel, object>>[] includes)
        {
            var user = _identityCheckContext.Users.FirstOrDefault(filter);
            //UserModel user;
            //if (includes!=null)
            //{
            //    user = _identityCheckContext.Users.Include(p => p.Role).FirstOrDefault(filter);
            //}
            //else
            //{
            //    user = _identityCheckContext.Users.FirstOrDefault(filter);
            //}
            return user;
        }


        public async Task<string> SetStatusCancel(int userId, bool userStatus)
        {
            try
            {
                var user = Get(p => p.Id == userId/*, p=>p.Role*/);
                user.Status = userStatus;
                _identityCheckContext.Users.Update(user);
                await _identityCheckContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return "İşleminiz Başarısız";
            }
            return "İşleminiz Başarılı";
        }


        public async Task<bool> ChangeProfilePicture(byte[] userProfilePicture, string userName)
        {
            var user = _identityCheckContext.Users.FirstOrDefault(p => p.Username == userName);
            if (userProfilePicture != null)
            {
                var stream = new MemoryStream(userProfilePicture);
                var formFile = new FormFile(stream, 0, userProfilePicture.Length, "file", "file.jpg");
                var result= PictureManagement.Add(formFile, user);
                if (result== "Kullanıcı Resimi Eklenildi.")
                {
                    _identityCheckContext.Users.Update(user);
                    _identityCheckContext.SaveChanges();
                    return await Task.FromResult(true);
                }
            }
            return await Task.FromResult(false);
        }

        public string GetProfilePicture(string userName)
        {
            var userProfilePicture = _identityCheckContext.Users.FirstOrDefault(p => p.Username == userName).ProfileImagePath;
            return userProfilePicture;
        }

        public async Task<List<Role>> GetRoles()
        {
            var roles = await _identityCheckContext.Roles.ToListAsync();
            return roles;
        }

        public async Task<bool> AddUser(UserModelDTO addUserModel, int roleId)
        {
            addUserModel.UserModel.Role = _identityCheckContext.Roles.FirstOrDefault(p => p.Id == roleId);
            addUserModel.UserModel.Phone = String.Format("{0:(000) 000 00 00}", Convert.ToInt64(addUserModel.UserModel.Phone));
            if (addUserModel.ProfilePicture != null)
            {
                var stream = new MemoryStream(addUserModel.ProfilePicture);
                var formFile = new FormFile(stream, 0, addUserModel.ProfilePicture.Length, "file", "file.jpg");
                var result = PictureManagement.Add(formFile,addUserModel.UserModel);
                if (result != "Kullanıcı Resimi Eklenildi.")
                {
                    return await Task.FromResult(false);
                }
                _identityCheckContext.Users.Update(addUserModel.UserModel);
                _identityCheckContext.SaveChanges();
                return await Task.FromResult(true);

            }
            return await Task.FromResult(false);
        }

        public async Task<bool> UpdateUser(UserModelDTO updateUser,string newPas)
        {
            try
            {

                updateUser.UserModel.Phone = String.Format("{0:(000) 000 00 00}", Convert.ToInt64(updateUser.UserModel.Phone));
                //var user = _identityCheckContext.Users.FirstOrDefault(p => p.Id == updateUser.UserModel.Id);

                var registeredUser = _identityCheckContext.Users.
                    Where(p => (p.Username == updateUser.UserModel.Username || p.Email == updateUser.UserModel.Email || p.Phone == updateUser.UserModel.Phone) && p.Status == true).ToList();
                if (registeredUser.Count>1)
                {
                    return await Task.FromResult(false);
                }
                UserModel user = await _identityCheckContext.Users.FindAsync(updateUser.UserModel.Id);
                if (updateUser.ProfilePicture != null)
                {
                    var stream = new MemoryStream(updateUser.ProfilePicture);
                    var formFile = new FormFile(stream, 0, updateUser.ProfilePicture.Length, "file", "file.jpg");
                    var result = PictureManagement.Update(formFile, user.ProfileImagePath);
                    if (result == "Dosya bulunamadı." || result == "Yanlış dosya tipi.")
                    {
                        return await Task.FromResult(false);
                    }
                    updateUser.UserModel.ProfileImagePath = result;
                }
                user.FirstName = updateUser.UserModel.FirstName;
                user.LastName = updateUser.UserModel.LastName;
                user.Email = updateUser.UserModel.Email;
                user.Phone = updateUser.UserModel.Phone;
                user.ProfileImagePath = updateUser.UserModel.ProfileImagePath;
                user.Role = updateUser.UserModel.Role;
                user.Status = updateUser.UserModel.Status;
                user.Username = updateUser.UserModel.Username;
                if (newPas != "null")
                {
                    user.Password = HashingHelper.SHA512(newPas);
                }
                //user = updateUser.UserModel;
                _identityCheckContext.Users.Update(user);
                _identityCheckContext.SaveChanges();
                return await Task.FromResult(true);
            }
            catch (Exception e)
            {
                var p = e.Message;
                return await Task.FromResult(false);
            }

        }
    }
}
