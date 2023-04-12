using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.Basket.Order
{
    public class OrderItem 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PicturePath { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Units { get; set; }
    }
}
