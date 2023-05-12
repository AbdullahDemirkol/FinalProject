using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Entity.Concrete.Helper
{
    public class UserModelDTO
    {
        public UserModel UserModel { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
