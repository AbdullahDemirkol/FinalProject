using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer
{
    public class Buyer
    {
        public string Name { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public Buyer(PaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

    }
}
