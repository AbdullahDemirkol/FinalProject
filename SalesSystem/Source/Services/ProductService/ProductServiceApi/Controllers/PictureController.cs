using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using ProductServiceApi.Helper;
using ProductServiceApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly ProductContext _productContext;
        ILogger<PictureController> _logger;

        public PictureController(ProductContext productContext, ILogger<PictureController> logger)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _logger = logger;
        }



        [HttpGet]
        [Route("pictures/{id}")]
        public ActionResult<Picture> GetByPictureId(string pictureId)
        {
            var result = _productContext.Pictures.SingleOrDefault(c => c.Id.ToString() == pictureId);
            _logger.LogInformation($"{pictureId} numaralı fotoğraf getirildi.");
            if (result == null)
            {
                return new Picture();
            }
            return result;
        }


        [HttpGet]
        [Route("pictures/{productId:int}")]
        public ActionResult<List<Picture>> GetByProductId(int productId)
        {
            var result = _productContext.Pictures.Where(c => c.ProductId == productId).ToList();
            _logger.LogInformation($"{productId} numaralı ürünün fotoğrafları getirildi.");

            if (result == null)
            {
                return new List<Picture>() { };
            }
            return result;
        }


        [HttpGet]
        [Route("pictures/productIds")]
        public ActionResult<List<Picture>> GetPicturesByProductIds(IEnumerable<Product> products)
        {
            List<Picture> pictures = new();
            foreach (var product in products)
            {
                var picture = _productContext.Pictures.SingleOrDefault(c => c.ProductId == product.Id);
                pictures.Add(picture);
            }
            _logger.LogInformation($"Birkaç ürünün fotoğrafları getirildi.");

            return pictures;

        }


        //----------------------------------------------------------------------------------------------------------


        [HttpPost]
        [Route("pictures/add")]
        public async Task<(string, Picture)> Add([FromForm(Name = "Image")] IFormFile file, [FromForm] Picture picture)
        {
            var result = await PictureManagement.Add(file, picture, _productContext);
            _logger.LogInformation($"Ürün resimi eklenildi.");
            return result;
        }


        [HttpDelete]
        [Route("pictures/delete/{pictureId:int}")]
        public async Task<string> Delete(int pictureId, int productId)
        {
            var result = await PictureManagement.Remove(pictureId, productId, _productContext);
            _logger.LogInformation($"Ürün resimi silindi.");
            return result;
        }


        [HttpPut]
        [Route("pictures/update")]
        public async Task<string> Update([FromForm(Name = "Image")] IFormFile file, [FromForm] Picture picture)
        {
            var result = await PictureManagement.Update(file, picture, _productContext);
            _logger.LogInformation($"Ürün resimi güncellendi.");
            return result;
        }


    }

}
