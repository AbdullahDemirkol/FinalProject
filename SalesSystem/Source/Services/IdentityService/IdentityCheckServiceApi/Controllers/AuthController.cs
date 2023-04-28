using IdentityCheckServiceApi.Business.Abstract;
using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Entity.Concrete.Helper;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;

        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequestModel loginRequestModel)
        {
            var result = await _identityService.Login(loginRequestModel);
            if (result.UserToken == null)
            {
                return NotFound(new { Message = "Kullanıcı adı veya parola hatalı." });
            }
            return Ok(result);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody]UserModel user)
        {
            var roleName = Role.FromName("user").Name;
            var result = await _identityService.Register(user, roleName);
            return Ok(result);
        }
        [HttpGet("users")]
        public async Task<ActionResult<PaginatedViewModel<UserModel>>> GetUsers(int pageSize=6,int pageIndex=0)
        {
            var result = await _identityService.GetUsers(pageSize,pageIndex);
            return result;
        }
        [HttpGet("Users/{userStatus:bool}")]
        public async Task<ActionResult<PaginatedViewModel<UserModel>>> GetUserStatus(bool userStatus,int pageSize = 6, int pageIndex = 0)
        {
            var result = await _identityService.GetUsers(pageSize,pageIndex,p => p.Status == userStatus);
            return result;
        }
        [HttpPost("SetUserStatus/{userId:int}")]
        public async Task<ActionResult<string>> SetUserStatus(int userId, [FromBody] bool userStatus)
        {
            var result = await _identityService.SetStatusCancel(userId,userStatus);

            return result;
        }
        [HttpPost("ChangePicture/{userName}")]
        public async Task<bool> ChangePicture([FromBody]byte[] userProfilePicture, string userName)
        {
            var result = await _identityService.ChangeProfilePicture(userProfilePicture, userName);
            if (result)
            {
                return true;
            }
            return false;
        }
        [HttpGet("GetPicture/{userName}")]
        public string GetPicture(string userName)
        {
            var result = _identityService.GetProfilePicture(userName);
            return result;
        }
        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles()
        {
            var result = await _identityService.GetRoles();
            return Ok(result);
        }
        [HttpPost("AddUser/{roleId}")]
        public async Task<bool> AddUser([FromBody]AddUserModel addUserModel, int roleId)
        {
            var result = await _identityService.AddUser(addUserModel,roleId);
            if (result)
            {
                return true;
            }
            return false;
        }
    }
}
