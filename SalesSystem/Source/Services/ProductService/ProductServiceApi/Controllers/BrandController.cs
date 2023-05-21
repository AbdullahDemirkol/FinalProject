using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly ProductContext _productContext;
        ILogger<BrandController> _logger;

        public BrandController(ProductContext productContext, ILogger<BrandController> logger)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _logger = logger;
        }
        [HttpGet]
        [Route("brands")]
        public async Task<ActionResult<List<Brand>>> BrandAsync(/*int pageSize = 6, int pageIndex = 0,string ids = null*/)
        {
            var brands = await _productContext.Brands/*.Skip(pageSize * pageIndex).Take(pageSize)*/.ToListAsync();
            _logger.LogInformation("Markalar getirildi.");

            return brands;
        }
        [HttpPost]
        [Route("brands/add")]
        public async Task<ActionResult> CreateBrandAsync(Brand brandToCreate)
        {
            var brand = new Brand
            {
                BrandName = brandToCreate.BrandName
            };
            _productContext.Brands.Add(brand);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation("Marka databaseye eklenildi.");
            return NoContent();
        }


        [HttpDelete]
        [Route("brands/delete/{id}")]
        public async Task<ActionResult> DeleteBrandAsync(int id)
        {
            var brand = _productContext.Brands.SingleOrDefault(p => p.Id == id);
            if (brand == null)
            {
                _logger.LogInformation($"{id} numaralı marka bulunamadı.");
                return NotFound(new { Message = $"{id} numaralı marka bulunamadı." });
            }
            _productContext.Brands.Remove(brand);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation($"{id} numaralı marka databaseden silindi.");


            return NoContent();
        }


        [HttpPut]
        [Route("brands/update")]
        public async Task<ActionResult> UpdateBrandAsync(Brand brandToUpdate)
        {
            var brand = await _productContext.Brands.SingleOrDefaultAsync(p => p.Id == brandToUpdate.Id);
            if (brand == null)
            {
                _logger.LogInformation($"{brandToUpdate.Id} numaralı marka bulunamadı.");
                return NotFound(new { Message = $"{brandToUpdate.Id} numaralı marka bulunamadı." });
            }
            brand = brandToUpdate;
            _productContext.Brands.Update(brand);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation($"{brandToUpdate.Id} numaralı marka güncellenildi.");

            return NoContent();
        }

    }
}
