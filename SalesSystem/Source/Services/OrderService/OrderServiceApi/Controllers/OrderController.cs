using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.Queries;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.RequestQueriesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost("cancelOrderStatus")]
        public async Task<IActionResult> SetOrderStatusIsCancelled([FromBody]Guid orderNumber)
        {
            var (IsUpdate,order) = await _mediator.Send(new UpdateOrderStatusCommand(orderNumber,OrderStatus.IptalEdildi.Id));
            if (IsUpdate== true)
            {
                var result = await _mediator.Send(new GetOrdersByUserNameQuery(order.Buyer.Name,0));
                return Ok(result);
            }
            return Ok();
        }
        [HttpGet("{buyerName}/OrderStatus/{orderStatusId:int}")]
        public async Task<IActionResult> GetOrdersByBuyerName(string buyerName, int orderStatusId)
        {
            var result = await _mediator.Send(new GetOrdersByUserNameQuery(buyerName, orderStatusId));
            return Ok(result);
        }

        //[HttpGet("{buyerName}/CardType/{cardTypeId:int}")]
        //public async Task<IActionResult> GetPaymentMethodsByBuyerName(string buyerName, int cardTypeId)
        //{
        //    var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, cardTypeId));
        //    return Ok(result);
        //}
        [HttpGet("orderStatuses")]
        public IActionResult GetOrderStatuses()
        {
            var orderStatuses = (List<OrderStatus>)OrderStatus.List();
            return Ok(orderStatuses);
        }
    }
}
