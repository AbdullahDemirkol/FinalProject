using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entity.Concrete.DTOs;
using WebApplication.Entity.Concrete.User;

namespace WebApplication.Business.Abstract
{
    public interface IIdentityService
    {
        string GetUsername();
        string GetUserToken();
        string GetUserExpiration();
        Task<bool> ChangePicture(IBrowserFile pictureFiles, string userName); 
        Task<string> GetPicture(string userName);
        UserDTO GetUserModel(string token);
        bool IsLoggedIn { get; }
        Task<bool> Login(string userName, string password);
        Task<string> Register(UserDTO userDTO);
        void Logout();
    }
}
