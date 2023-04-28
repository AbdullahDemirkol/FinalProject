using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Entity.Concrete
{
    public class AddUserProfilePictureModel
    {
        public List<byte[]> ProductImageFiles { get; set; }
    }
}
