using BasketServiceApi.Entity.Concrete;
using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.IntegrationEvents.Events
{
    public class OrderCreatedIntegrationEvent : IntegrationEvent
    {
        public OrderCreatedIntegrationEvent(string userName, BasketCardInformationItem basketCardInformationItem, CustomerBasket customerBasket)
        {
            Username = userName;
            BasketCardInformationItem = basketCardInformationItem;
            CustomerBasket = customerBasket;

        }
        public string Username { get; private set; }
        public BasketCardInformationItem BasketCardInformationItem { get; set; }
        public CustomerBasket CustomerBasket { get; }

    }
}
