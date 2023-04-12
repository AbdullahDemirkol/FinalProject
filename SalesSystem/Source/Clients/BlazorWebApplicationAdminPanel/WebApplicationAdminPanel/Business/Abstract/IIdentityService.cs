using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IIdentityService
    {
        string GetUsername();
        string GetUserToken();
        string GetUserExpiration();
        UserDTO GetUserModel(string token);
        bool IsLoggedIn { get; }
        Task<bool> Login(string userName, string password);
        void Logout();
    }
}
