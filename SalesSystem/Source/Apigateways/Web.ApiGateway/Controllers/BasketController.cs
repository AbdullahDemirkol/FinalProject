﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ApiGateway.Business.Abstract;
using Web.ApiGateway.Entity.Concrete.Basket;

namespace Web.ApiGateway.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService, IProductService productService)
        {
            _basketService = basketService;
            _productService = productService;
        }

        [HttpPost]
        [Route("addBasketItem")]
        public async Task<ActionResult> AddBasketItemAsync([FromBody]AddBasketItemRequest request)
        {

            if (request is null || request.Quantity == 0)
            {
                return BadRequest("Miktar Hatalı");
            }
            var item = await _productService.GetProductItemAsync(request.ProductItemId);
            var currentBasket = await _basketService.GetById(request.BasketId);
            var product = currentBasket.BasketItems.SingleOrDefault(p => p.ProductId == item.Id);

            if (product != null)
            {
                product.Quantity += request.Quantity;
            }
            else
            {
                currentBasket.BasketItems.Add(new BasketItem()
                {
                    UnitPrice = item.Price,
                    PictureUrl = item.PicturePath,
                    ProductId = item.Id,
                    Quantity = request.Quantity,
                    Id = Guid.NewGuid().ToString(),
                    ProductName = item.Name
                });
            }
            await _basketService.UpdateAsync(currentBasket);

            return Ok();

        }
    }
}
