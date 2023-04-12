﻿using BasketServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Entity.Concrete
{
    public class BasketCardInformationItem:IEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime CardExpiration { get; set; }
        public string CardSecurityNumber { get; set; }
        public int CardTypeId { get; set; }
        public string BuyerName{ get; set; }
    }
}