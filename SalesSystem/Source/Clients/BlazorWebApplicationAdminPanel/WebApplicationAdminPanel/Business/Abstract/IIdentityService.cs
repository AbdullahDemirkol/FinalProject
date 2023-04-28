using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Helper;
using WebApplicationAdminPanel.Entity.Concrete.User;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IIdentityService
    {
        string GetUsername();
        string GetUserToken();
        string GetUserExpiration();
        bool IsLoggedIn { get; }
        Task<bool> Login(string userName, string password);
        void Logout();
        UserDTO GetUserModel(string token);
        Task<PaginatedViewModel<UserDTO>> GetUsers(int pageSize , int pageIndex );
        Task<bool> RemoveUser(int userId);
        Task<List<Role>> GetRoles();
        Task<bool> AddUser(AddUserModel addUserModel, int roleId);

    }
}
