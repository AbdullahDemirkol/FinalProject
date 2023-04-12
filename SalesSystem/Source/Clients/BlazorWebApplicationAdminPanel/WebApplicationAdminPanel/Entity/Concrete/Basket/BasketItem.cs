﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Basket
{
    public class BasketItem
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public decimal BasketItemTotalUnitPrice()
        {
            return UnitPrice * Quantity;
        }
    }
}
