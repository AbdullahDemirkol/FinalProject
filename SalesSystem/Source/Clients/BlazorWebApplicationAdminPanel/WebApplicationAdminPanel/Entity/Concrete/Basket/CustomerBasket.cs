using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Basket
{
    public class CustomerBasket
    {
        public string UserName { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
        public int TotalQuantity()
        {
            int total = 0;
            foreach (var basketItem in BasketItems)
            {
                total += basketItem.Quantity;
            }
            return total;
        }
        public decimal TotalUnitPrice()
        {
            return Math.Round(BasketItems.Sum(p => p.UnitPrice * p.Quantity), 2);
        }
    }
}
