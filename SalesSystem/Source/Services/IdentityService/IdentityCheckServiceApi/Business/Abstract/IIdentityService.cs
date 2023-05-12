using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Entity.Concrete.Helper;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Business.Abstract
{
    public interface IIdentityService
    {
        Task<LoginResponseModel> Login(LoginRequestModel loginRequestModel);
        Task<string> Register(UserModel user,string roleName);
        Task<PaginatedViewModel<UserModel>> GetUsers(int pageSize, int pageIndex, Expression<Func<UserModel, bool>> filter = null, Func<IQueryable<UserModel>, IOrderedQueryable<UserModel>> orderBy = null);
        //Task<UserModel> Get(Expression<Func<UserModel, bool>> filter = null);
        Task<string> SetStatusCancel(int userId, bool userStatus);
        Task<bool> ChangeProfilePicture(byte[] userProfilePicture, string userName);
        string GetProfilePicture(string userName);
        Task<List<Role>> GetRoles(); 
        Task<bool> AddUser(UserModelDTO addUserModel, int roleId);
        Task<bool> UpdateUser(UserModelDTO updateUserModel,string newPas);
    }
}
