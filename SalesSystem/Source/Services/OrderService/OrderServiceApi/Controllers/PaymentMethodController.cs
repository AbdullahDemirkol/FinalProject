using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetOrderDetailById.RequestQueriesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentMethodController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        [HttpPost("addPaymentMethod/{userName}")]
        public async Task<IActionResult> AddPaymentMethod([FromBody] PaymentMethod paymentMethod,string userName)
        {
            var (IsUpdate, buyerName) = await _mediator.Send(new AddPaymentMethodCommand(paymentMethod, userName));

            var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, 0));
            return Ok(result);
            //if (IsUpdate == true)
            //{
            //}
            //return Ok();
        }
        [HttpPost("cancelPaymentMethod")]
        public async Task<IActionResult> SetPaymentMethodStatusIsFalse([FromBody] Guid PaymentMethodId)
        {
            var (IsUpdate, buyerName) = await _mediator.Send(new UpdatePaymentMethodCommand(PaymentMethodId,0));
            if (IsUpdate == true)
            {
                var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, 0));
                return Ok(result);
            }
            return Ok();
        }
        //[HttpGet("{buyerName}/OrderStatus/{orderStatusId:int}")]
        //public async Task<IActionResult> GetOrdersByBuyerName(string buyerName, int orderStatusId)
        //{
        //    var result = await _mediator.Send(new GetOrdersByUserNameQuery(buyerName, orderStatusId));
        //    return Ok(result);
        //}

        [HttpGet("{buyerName}/CardType/{cardTypeId:int}")]
        public async Task<IActionResult> GetPaymentMethodsByBuyerName(string buyerName, int cardTypeId)
        {
            var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, cardTypeId));
            return Ok(result);
        }
        [HttpGet("cardTypes")]
        public IActionResult GetCardTypes()
        {
            var cardTypes = (List<CardType>)CardType.List();
            return Ok(cardTypes);
        }
    }
}
