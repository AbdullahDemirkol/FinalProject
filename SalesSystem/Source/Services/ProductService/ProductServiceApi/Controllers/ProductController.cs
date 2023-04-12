using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using ProductServiceApi.Entity.Concrete.Helper;
using ProductServiceApi.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _productContext;

        public ProductController(ProductContext productContext)
        {
            _productContext = productContext ?? throw new ArgumentNullException(nameof(productContext));
        }


        [HttpGet]
        [Route("products")]
        public async Task<IActionResult> ProductAsync(int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var products = await GetProductsByIdsAsync(ids);
                if (!products.Any())
                {
                    return BadRequest();
                }
                return Ok(products);
            }
            var totalProductCount = await _productContext.Products.LongCountAsync();

            var productsOnPage = await _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).OrderBy(p => p.Name).Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }
        private async Task<List<Product>> GetProductsByIdsAsync(string ids)
        {
            var numIds = ids.Split(',').Select(id => (Ok: int.TryParse(id, out int x), Value: x));
            if (!numIds.All(nid => nid.Ok))
            {
                return new List<Product>();
            }

            var idsToSelect = numIds.Select(id => id.Value);

            var products = await _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => idsToSelect.Contains(p.Id)).ToListAsync();
            return products;
        }


        [HttpGet]
        [Route("products/{id:int}")]
        public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
        {

            if (id <= 0)
            {
                return BadRequest();
            }

            var product = await _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).SingleOrDefaultAsync(p => p.Id == id);
            
            if (product != null)
            {
                return product;
            }
            return NotFound();
        }


        [HttpGet]
        [Route("products/withname/{name:minlength(1)}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductByNameAsync(string name, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.Name.StartsWith(name));
            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        //----------------------------------------------------------------------------------------------------------

        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByUpCatalogIdAsync(int upCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        [HttpGet]
        [Route("products/downCategoryId/{downCategoryId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByDownCatalogIdAsync(int downCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.DownCategoryId == downCategoryId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        [HttpGet]
        [Route("products/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAsync(int brandId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }
        
        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAndUpCategoryIdAsync(int brandId, int upCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }
        
        [HttpGet]
        [Route("products/downCategoryId/{downCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAndDownCategoryIdAsync(int brandId, int downCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.DownCategoryId == downCategoryId && p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }


        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/downCategoryId/{downCategoryId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByUpAndDownCatalogIdAsync(int upCategoryId,int downCategory, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.DownCategoryId==downCategory);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }


        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/downCategoryId/{downCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByUpAndDownCatalogIdAsync(int upCategoryId, int downCategoryId,int brandId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.DownCategoryId == downCategoryId && p.BrandId == brandId); ;

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }



        //----------------------------------------------------------------------------------------------------------
        [HttpPost]
        [Route("products/add")]
        public async Task<ActionResult<string>> CreateProductAsync([FromHeader] Product productToCreate,[FromForm(Name = "Image")] IFormFile file, [FromForm(Name = "Image1")] IFormFile? file1, [FromForm(Name = "Image2")] IFormFile? file2)
        {
            if (productToCreate.UpCategoryId > 0 && productToCreate.DownCategoryId > 0 && productToCreate.BrandId > 0)
            {
                var product = new Product
                {
                    Name = productToCreate.Name,
                    Price = productToCreate.Price,
                    Description = productToCreate.Description,
                    BrandId = productToCreate.BrandId,
                    UpCategoryId = productToCreate.UpCategoryId,
                    DownCategoryId = productToCreate.DownCategoryId
                };

                _productContext.Products.Add(product);
                await _productContext.SaveChangesAsync();
                List<IFormFile> files=new List<IFormFile>();
                List<string> results = new List<string>();
                files.Add(file);
                if (file1 != null)
                {
                    files.Add(file1);
                }
                if (file2 != null)
                {
                    files.Add(file2);
                }
                foreach (var pictureFile in files)
                {
                    var picture = new Picture(product.Id);
                    var result = await PictureManagement.Add(pictureFile, picture, _productContext);
                    results.Add(result.Item1);
                    product.Pictures.Add(result.Item2);

                }
                foreach (var result in results)
                {
                    if (result != "Ürün Resimi Eklenildi.")
                    {
                        return result;
                    }
                }
                await _productContext.SaveChangesAsync();


                return Ok(new { Message = "Ürün Eklenildi." });
            }
            return "Kategori yada Markayla İlgili Bilgi Yanlış.";
        }


        [HttpDelete]
        [Route("products/delete/{id}")]
        public async Task<ActionResult> DeleteProductAsync(int id)
        {
            List<string> results = new List<string>();
            var product = _productContext.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = $"{id} numaralı id'ye ait product bulunamadı." });
            }
            foreach (var picture in product.Pictures)
            {
                var result = await PictureManagement.Remove(picture.Id, product.Id, _productContext);
                results.Add(result);
            }
            _productContext.Products.Remove(product);
            await _productContext.SaveChangesAsync();
            foreach (var result in results)
            {
                if (result != "Ürün Resimi Silindi.")
                {
                    return NotFound(new { Message = "Resimleri silerken hata oluştu.Ama ürün silindi." });
                }
            }
            return Ok(new { Message = "Başarılı bir şekilde ürün silme işlemi gerçekleştirildi." });
        }


        [HttpPut]
        [Route("products/update")]
        public async Task<ActionResult> UpdateProductAsync(Product productToUpdate)
        {
            var product = await _productContext.Products.SingleOrDefaultAsync(p => p.Id == productToUpdate.Id);
            if (product == null)
            {
                return NotFound(new { Message = $"{productToUpdate.Id} numaralı id'ye ait ürün bulunamadı." });
            }
            product.BrandId = productToUpdate.BrandId;
            product.DownCategoryId = productToUpdate.DownCategoryId;
            product.Description = productToUpdate.Description;
            product.Name = productToUpdate.Name;
            product.Price = productToUpdate.Price;
            product.UpCategoryId = productToUpdate.UpCategoryId;

            _productContext.Products.Update(product);
            await _productContext.SaveChangesAsync();
            return Ok(new { Message = "Ürün başarılı bir şekilde güncellenildi." });
        }


        [HttpPut]
        [Route("products/picture/update/{productId}")]
        public async Task<ActionResult<string>> UpdateProductAsync([FromForm(Name = "Image")] IFormFile file, int productId)
        {
            var picture = await _productContext.Pictures.SingleOrDefaultAsync(p => p.ProductId == productId);
            if (picture == null)
            {
                return $"{productId} numaralı id'ye ait fotoğraf bulunamadı." ;
            }
            var result= await PictureManagement.Update(file, picture, _productContext);
            return Ok(new { Message = result });
        }

        //----------------------------------------------------------------------------------------------------------

    }
}
