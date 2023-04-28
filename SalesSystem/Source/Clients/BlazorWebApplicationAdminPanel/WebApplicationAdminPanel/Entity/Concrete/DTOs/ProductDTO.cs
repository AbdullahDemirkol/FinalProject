using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.DTOs
{
    public class ProductDTO
    {
        public Product.Product Product { get; set; }
        public List<byte[]> ProductImageFiles { get; set; }
    }
}
