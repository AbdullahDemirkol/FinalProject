using MediatR;
using OrderServiceApi.Entity.Concrete.Helper.Models;
using OrderServiceApi.Entity.Concrete.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel
{
    public class CreateOrderCommand : IRequest<bool>
    {
        private readonly List<OrderItem> _orderItems;

        public string UserName { get; set; }
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
        public IEnumerable<OrderItem> OrderItems => _orderItems;

        public CreateOrderCommand()
        {
            _orderItems = new List<OrderItem>();
        }

        public CreateOrderCommand(BasketCardInformationItem basketCardInformationItem, CustomerBasket customerBasket) : this()
        {
            _orderItems = customerBasket.BasketItems.Select(p => new OrderItem(p.ProductId, p.ProductName, p.PictureUrl, p.UnitPrice, p.Quantity)).ToList();
            UserName = basketCardInformationItem.BuyerName;
            City = basketCardInformationItem.City;
            Street = basketCardInformationItem.Street;
            State = basketCardInformationItem.State;
            Country = basketCardInformationItem.Country;
            ZipCode = basketCardInformationItem.ZipCode;
            CardNumber = basketCardInformationItem.CardNumber;
            CardHolderName = basketCardInformationItem.CardHolderName;
            CardExpiration = basketCardInformationItem.CardExpiration;
            CardSecurityNumber = basketCardInformationItem.CardSecurityNumber;
            CardTypeId = basketCardInformationItem.CardTypeId;
        }
    }

}
