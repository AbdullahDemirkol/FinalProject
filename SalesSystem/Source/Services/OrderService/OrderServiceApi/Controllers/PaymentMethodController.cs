using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrderServiceApi.Entity.Concrete.Buyer;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel;
using OrderServiceApi.IntegrationEvents.QueriesFeatures.Queries.GetMethods.RequestQueriesModel;
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
        public async Task<string> AddPaymentMethod([FromBody] PaymentMethod paymentMethod, string userName, int pageSize = 6, int pageIndex = 0)
        {
            var result = await _mediator.Send(new AddPaymentMethodCommand(paymentMethod, userName));
            if (result)
            {
                return "Ödeme Yöntemi Eklenildi.";
            }
            return "Ödeme Yöntemi Eklenirken Hata Oluştu.";
        }
        [HttpPost("cancelPaymentMethodByBuyer/{buyerName}")]
        public async Task<IActionResult> SetPaymentMethodStatusIsFalseByBuyerName([FromBody] Guid PaymentMethodId, string buyerName)
        {
            var result = await _mediator.Send(new UpdatePaymentMethodCommand(PaymentMethodId, buyerName, 0));
            if (result)
            {
                return Ok();
            }
            return BadRequest();
            //var (IsUpdate, buyerName) = await _mediator.Send(new UpdatePaymentMethodCommand(PaymentMethodId, 0));
            //if (IsUpdate == true)
            //{
            //    var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, 0, pageSize, pageIndex));
            //    return Ok(result);
            //}
            //return Ok();
        }

        [HttpGet("{buyerName}/CardType/{cardTypeId:int}")]
        public async Task<IActionResult> GetPaymentMethodsByBuyerName(string buyerName, int cardTypeId, int pageSize = 6, int pageIndex = 0)
        {
            var result = await _mediator.Send(new GetPaymentMethodsByUserNameQuery(buyerName, cardTypeId, pageSize, pageIndex));
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
