using BasketServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Entity.Concrete
{
    public class CustomerBasket:IEntity
    {
        public CustomerBasket(string userName)
        {
            UserName = userName;
            BasketItems = new List<BasketItem>();
        }
        public string UserName { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
    }
}
