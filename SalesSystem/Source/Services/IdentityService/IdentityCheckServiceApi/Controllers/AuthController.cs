using IdentityCheckServiceApi.Business.Abstract;
using IdentityCheckServiceApi.Entity.Concrete;
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
        public async Task<ActionResult<string>> Register(UserModel user)
        {
            user.Role = Role.FromName("User");
            var result = await _identityService.Register(user);
            return result;
        }
        [HttpPost("Register/{RoleId:int}")]
        public async Task<ActionResult<string>> RegisterByRoleId(UserModel user,int id)
        {
            user.Role = Role.FromId(id);
            var result = await _identityService.Register(user);
            return result;
        }
    }
}
