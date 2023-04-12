using BasketServiceApi.Business.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BasketServiceApi.Business.Concrete
{

    public class IdentityManager : IIdentityService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserName()
        {
            return _httpContextAccessor.HttpContext.User.FindFirst(p => p.Type == ClaimTypes.NameIdentifier).Value;
        }
    }
}
