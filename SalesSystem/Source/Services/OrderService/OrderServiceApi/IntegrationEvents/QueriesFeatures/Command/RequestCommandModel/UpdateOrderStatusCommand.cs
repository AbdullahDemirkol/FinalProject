using MediatR;
using OrderServiceApi.Entity.Concrete.Order;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel
{
    public class UpdateOrderStatusCommand : IRequest<(bool,Order)>
    {
        public Guid OrderNumber { get; set; }
        public int OrderStatusId { get; set; }
        public UpdateOrderStatusCommand(Guid orderNumber,int orderStatusId)
        {
            OrderNumber = orderNumber;
            OrderStatusId = orderStatusId;
        }
    }
}
