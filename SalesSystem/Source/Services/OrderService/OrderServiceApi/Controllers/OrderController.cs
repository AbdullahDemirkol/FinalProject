using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.Queries;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel;
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
        [HttpPost("setOrderStatus/{statusId}/buyerName/{buyerName}")]
        public async Task<IActionResult> SetOrderStatus([FromBody] Guid orderNumber, string buyerName,int statusId)
        {
            try
            {
                var result = await _mediator.Send(new UpdateOrderStatusCommand(orderNumber, buyerName, OrderStatus.FromId(statusId).Id));
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("cancelOrderStatusByBuyer/{buyerName}")]
        public async Task<IActionResult> SetOrderStatusIsCancelledByBuyerName([FromBody]Guid orderNumber,string buyerName)
        {
            try
            {
                var result= await _mediator.Send(new UpdateOrderStatusCommand(orderNumber, buyerName, OrderStatus.IptalEdildi.Id));
                if (result)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("cancelOrderStatus")]
        public async Task<IActionResult> SetOrderStatusIsCancelled([FromBody] Guid orderNumber, int pageSize = 6, int pageIndex = 0)
        {
            var IsUpdate = await _mediator.Send(new UpdateOrderStatusCommand(orderNumber,"", OrderStatus.IptalEdildi.Id));
            if (IsUpdate == true)
            {
                var result = await _mediator.Send(new GetOrdersQuery(0, pageSize, pageIndex));
                return Ok(result);
            }
            return Ok();
        }
        [HttpGet("{buyerName}/OrderStatus/{orderStatusId:int}")]
        public async Task<IActionResult> GetOrdersByBuyerName(string buyerName, int orderStatusId, int pageSize = 6, int pageIndex = 0)
        {
            var result = await _mediator.Send(new GetOrdersByUserNameQuery(buyerName, orderStatusId, pageSize, pageIndex));
            return Ok(result);
        }
        [HttpGet("orders/{orderStatusId:int}")]
        public async Task<IActionResult> GetOrders(int orderStatusId, int pageSize = 6, int pageIndex = 0)
        {
            var result = await _mediator.Send(new GetOrdersQuery(orderStatusId, pageSize, pageIndex));
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
