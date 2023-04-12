using IdentityCheckServiceApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Business.Abstract
{
    public interface IIdentityService
    {
        Task<LoginResponseModel> Login(LoginRequestModel loginRequestModel);
        Task<string> Register(UserModel user);
    }
}
