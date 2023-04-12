using EventBus.Base.Entity.Concrete;
using OrderServiceApi.Entity.Concrete.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public OrderCreatedIntegrationEvent(string userName, BasketCardInformationItem basketCardInformationItem, Guid requestId, CustomerBasket customerBasket)
        {
            BasketCardInformationItem = basketCardInformationItem;
            Buyer = userName;
            RequestId = requestId;
            CustomerBasket = customerBasket;
        }

        public BasketCardInformationItem BasketCardInformationItem { get; set; }
        public string Buyer { get; set; }
        public CustomerBasket CustomerBasket { get; }
        public Guid RequestId { get; set; }


    }
}
