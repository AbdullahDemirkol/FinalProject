using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public BrandController(ProductContext productContext)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
        }
        [HttpGet]
        [Route("brands")]
        public async Task<ActionResult<List<Brand>>> BrandAsync(/*int pageSize = 6, int pageIndex = 0,string ids = null*/)
        {
            var brands = await _productContext.Brands/*.Skip(pageSize * pageIndex).Take(pageSize)*/.ToListAsync();
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
            return NoContent();
        }


        [HttpDelete]
        [Route("brands/delete/{id}")]
        public async Task<ActionResult> DeleteBrandAsync(int id)
        {
            var brand = _productContext.Brands.SingleOrDefault(p => p.Id == id);
            if (brand == null)
            {
                return NotFound(new { Message = $"{id} numaralı id'ye ait marka bulunamadı." });
            }
            _productContext.Brands.Remove(brand);
            await _productContext.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut]
        [Route("brands/update")]
        public async Task<ActionResult> UpdateBrandAsync(Brand brandToUpdate)
        {
            var brand = await _productContext.Brands.SingleOrDefaultAsync(p => p.Id == brandToUpdate.Id);
            if (brand == null)
            {
                return NotFound(new { Message = $"{brandToUpdate.Id} numaralı id'ye ait marka bulunamadı." });
            }
            brand = brandToUpdate;
            _productContext.Brands.Update(brand);
            await _productContext.SaveChangesAsync();
            return NoContent();
        }

    }
}
