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
    public class UpCategoryController : ControllerBase
    {
        private readonly ProductContext _productContext;
        ILogger<UpCategoryController> _logger;
        public UpCategoryController(ProductContext productContext, ILogger<UpCategoryController> logger)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
            _logger = logger;
        }
        [HttpGet]
        [Route("upCategories")]
        public async Task<ActionResult<List<UpCategory>>> UpCategoryAsync(/*int pageSize = 6, int pageIndex = 0, string ids = null*/)
        {
            var categories = await _productContext.UpCategories/*.Skip(pageSize * pageIndex).Take(pageSize)*/.ToListAsync();
            _logger.LogInformation("Üst kategoriler getirildi.");
            return categories;
        }
        [HttpPost]
        [Route("upCategories/add")]
        public async Task<ActionResult> CreateUpCategoryAsync(UpCategory upCategoryToCreate)
        {
            var category = new UpCategory
            {
                UpCategoryName = upCategoryToCreate.UpCategoryName
            };
            _productContext.UpCategories.Add(category);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation("Üst kategori databaseye eklenildi.");
            return NoContent();
        }


        [HttpDelete]
        [Route("upCategories/delete/{id}")]
        public async Task<ActionResult> DeleteUpCategoryAsync(int id)
        {
            var downCategory = _productContext.DownCategories.Where(p => p.UpCategoryId == id).ToList();
            if (downCategory != null)
            {
                _productContext.DownCategories.RemoveRange(downCategory);
                await _productContext.SaveChangesAsync();
            }
            var upCategory = _productContext.UpCategories.SingleOrDefault(p => p.Id == id);
            if (upCategory == null)
            {
                _logger.LogInformation($"{id} numaralı üst kategori bulunamadı.");
                return NotFound(new { Message = $"{id} numaralı üst kategori bulunamadı." });
            }
            _productContext.UpCategories.Remove(upCategory);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation($"{id} numaralı üst kategori databaseden silindi.");

            return NoContent();
        }


        [HttpPut]
        [Route("upCategories/update")]
        public async Task<ActionResult> UpdateUpCategoryAsync(UpCategory upCategoryToUpdate)
        {
            var upCategory = await _productContext.UpCategories.SingleOrDefaultAsync(p => p.Id == upCategoryToUpdate.Id);
            if (upCategory == null)
            {
                _logger.LogInformation($"{upCategoryToUpdate.Id} numaralı üst kategori bulunamadı.");
                return NotFound(new { Message = $"{upCategoryToUpdate.Id} numaralı üst kategori bulunamadı." });
            }
            upCategory = upCategoryToUpdate;
            _productContext.UpCategories.Update(upCategory);
            await _productContext.SaveChangesAsync();
            _logger.LogInformation($"{upCategoryToUpdate.Id} numaralı üst kategori güncellenildi.");
            return NoContent();
        }
    }
}
