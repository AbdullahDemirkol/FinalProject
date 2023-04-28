using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Entity.Concrete.Helper
{
    public class AddProduct
    {
        public Product Product { get; set; }
        public List<byte[]> ProductImageFiles { get; set; }
    }
}
