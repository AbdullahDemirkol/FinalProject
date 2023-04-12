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
    public class DownCategoryController : ControllerBase
    {
        private readonly ProductContext _productContext;
        public DownCategoryController(ProductContext productContext)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));

        }
        [HttpGet]
        [Route("downCategories")]
        public async Task<ActionResult<List<DownCategory>>> DownCategoryAsync(/*int pageSize = 6, int pageIndex = 0, string ids = null*/)
        {
            var categories = await _productContext.DownCategories/*.Skip(pageSize * pageIndex).Take(pageSize)*/.ToListAsync();
            return categories;
        }
        [HttpPost]
        [Route("downCategories/add")]
        public async Task<ActionResult> CreateDownCategoryAsync(DownCategory downCategoryToCreate)
        {
            var downCategory = new DownCategory
            {
                UpCategoryId = downCategoryToCreate.UpCategoryId,
                DownCategoryName = downCategoryToCreate.DownCategoryName
            };
            _productContext.DownCategories.Add(downCategory);
            await _productContext.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete]
        [Route("downCategories/delete/{id}")]
        public async Task<ActionResult> DeleteDownCategoryAsync(int id)
        {
            var downCategory = _productContext.UpCategories.SingleOrDefault(p => p.Id == id);
            if (downCategory == null)
            {
                return NotFound(new { Message = $"{id} numaralı id'ye ait üst kategori bulunamadı." });
            }
            _productContext.UpCategories.Remove(downCategory);
            await _productContext.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut]
        [Route("downCategories/update")]
        public async Task<ActionResult> UpdateDownCategoryAsync(DownCategory downCategoryToUpdate)
        {
            var downCategory = await _productContext.DownCategories.SingleOrDefaultAsync(p => p.Id == downCategoryToUpdate.Id);
            if (downCategory == null)
            {
                return NotFound(new { Message = $"{downCategoryToUpdate.Id} numaralı id'ye ait üst kategori bulunamadı." });
            }
            downCategory = downCategoryToUpdate;
            _productContext.DownCategories.Update(downCategory);
            await _productContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
