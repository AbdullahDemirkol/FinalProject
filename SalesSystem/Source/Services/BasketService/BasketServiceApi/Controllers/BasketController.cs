using BasketServiceApi.Business.Abstract;
using BasketServiceApi.DataAccess.Abstract;
using BasketServiceApi.Entity.Concrete;
using BasketServiceApi.IntegrationEvents.Events;
using EventBus.Base.EventBus.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IIdentityService _identityService;
        private readonly IEventBus _eventBus;
        private readonly ILogger<BasketController> _logger;

        public BasketController(IBasketRepository basketRepository, IIdentityService identityService, IEventBus eventBus, ILogger<BasketController> logger)
        {
            _basketRepository = basketRepository;
            _identityService = identityService;
            _eventBus = eventBus;
            _logger = logger;
        }
        
        [HttpGet("{requestUserName}")]
        public async Task<ActionResult> GetBasketByIdAsync(string requestUserName)
        {
            var userName = _identityService.GetUserName();
            if (userName==requestUserName)
            {
                var basket = await _basketRepository.GetBasketAsync(requestUserName);
                if (basket == null)
                {
                    basket = new CustomerBasket(requestUserName);
                }
                return Ok(basket);
            }
            return NotFound("Hatalı istekte bulunuldu.");
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<CustomerBasket>> UpdateBasketAsync(CustomerBasket newCustomerBasket)
        {
            var result = await _basketRepository.UpdateBasketAsync(newCustomerBasket);
            return Ok(result);
        }

        [HttpPost]
        [Route("additem")]
        public async Task<ActionResult> AddItemToBasket(BasketItem basketItem)
        {
            var userName = _identityService.GetUserName();
            var basket = await _basketRepository.GetBasketAsync(userName);
            if (basket == null)
            {
                basket = new CustomerBasket(userName);
            }
            basket.BasketItems.Add(basketItem);
            await _basketRepository.UpdateBasketAsync(basket);

            return Ok(/*"Ürün Sepete Eklenildi."*/);
        }

        [HttpPost]
        [Route("checkout")]
        public async Task<ActionResult> CheckOutAsync(BasketCardInformationItem basketCardInformationItem)
        {
            var buyerName = basketCardInformationItem.BuyerName;

            var basket = await _basketRepository.GetBasketAsync(buyerName);

            if (basket == null)
            {
                return BadRequest();
            }
            var userName = _identityService.GetUserName();

            var eventMessage = new OrderCreatedIntegrationEvent(userName, basketCardInformationItem, basket);
            try
            {
                _eventBus.Publish(eventMessage);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Hata. Publish entegrasyon eventi sırasında hata oluştu:{IntegrationEventId} from {BasketService.App}", eventMessage.Id);
                throw;
            }

            return Accepted();
        }

        [HttpDelete("delete")]
        public async Task<ActionResult> DeleteBasketByIdAsync()
        {
            var userName = _identityService.GetUserName().ToString();
            await _basketRepository.DeleteBasketAsync(userName);
            return Ok("Sepet başarıyla temizlendi.");
        }

    }
}
