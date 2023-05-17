using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using ProductServiceApi.Entity.Concrete.Helper;
using ProductServiceApi.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<IActionResult> ProductAsync(int upCategoryId, int downCategoryId, int brandId, int pageSize = 6, int pageIndex = 0, string ids = null)
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
            var productQuery = _productContext.Products
                    .Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Include(p => p.Pictures)
                    .Where(p => upCategoryId != 0 ? p.UpCategoryId == upCategoryId : true)
                    .Where(p => downCategoryId != 0 ? p.DownCategoryId == downCategoryId : true)
                    .Where(p => brandId != 0 ? p.BrandId == brandId : true);
            
            var totalProductCount = await productQuery.LongCountAsync();

            var productsOnPage = await productQuery.OrderBy(p => p.Name).Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();


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

            var products = await _productContext.Products.Include(p=>p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => idsToSelect.Contains(p.Id)).ToListAsync();
            return products;
        }
        [HttpGet]
        [Route("products/Search")]
        public IActionResult SearchProductAsync(string searchText, int pageIndex = 0, int pageSize = 6)
        {
            if (searchText!=null)
            {
                if (!string.IsNullOrEmpty(searchText))
                {
                    var productQuery = _productContext.Products
                            .Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Include(p => p.Pictures)
                            .Where(p => p.Name.ToLower().Contains(searchText.ToLower())).ToList();
                    var totalProductCount = productQuery.LongCount();

                    var productsOnPage = productQuery.OrderBy(p => p.Name).Skip(pageSize * pageIndex).Take(pageSize).ToList();


                    var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);
                    return Ok(model);
                }
            }
            return Ok();
            //if (productQuery.Count!=0)
            //{
            //    foreach (var item in productQuery)
            //    {
            //        var name = item.Name; 
            //        if (item != null && item.Name != null )
            //        {
            //            // item.Name içinde searchText değeri bulunuyor
            //            // İlgili işlemleri burada yapabilirsiniz
            //        }
            //        var sad=name.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
            //        if (sad)
            //        {

            //        }
            //    }
            //    var pasd = productQuery.Where(p => p.Name.Contains(searchText)).ToList();
            //}

        }


        [HttpGet]
        [Route("products/{id:int}")]
        public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
        {

            if (id <= 0)
            {
                return BadRequest();
            }

            var product = await _productContext.Products.Include(p=>p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).SingleOrDefaultAsync(p => p.Id == id);
            
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
            var products = _productContext.Products.Include(p=>p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.Name.StartsWith(name));
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
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        [HttpGet]
        [Route("products/downCategoryId/{downCategoryId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByDownCatalogIdAsync(int downCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p=>p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.DownCategoryId == downCategoryId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        [HttpGet]
        [Route("products/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAsync(int brandId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }
        
        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAndUpCategoryIdAsync(int brandId, int upCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }
        
        [HttpGet]
        [Route("products/downCategoryId/{downCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByBrandIdAndDownCategoryIdAsync(int brandId, int downCategoryId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.DownCategoryId == downCategoryId && p.BrandId == brandId);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }


        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/downCategoryId/{downCategoryId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByUpAndDownCatalogIdAsync(int upCategoryId,int downCategory, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.DownCategoryId==downCategory);

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }


        [HttpGet]
        [Route("products/upCategoryId/{upCategoryId:int}/downCategoryId/{downCategoryId:int}/brandId/{brandId:int}")]
        public async Task<ActionResult<PaginatedViewModel<Product>>> ProductsByUpAndDownCatalogIdAsync(int upCategoryId, int downCategoryId,int brandId, int pageSize = 6, int pageIndex = 0, string ids = null)
        {
            var products = _productContext.Products.Include(p => p.Pictures).Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Where(p => p.UpCategoryId == upCategoryId && p.DownCategoryId == downCategoryId && p.BrandId == brandId); ;

            var totalProductCount = await products.LongCountAsync();

            var productsOnPage = await products.Skip(pageSize * pageIndex).Take(pageSize).ToListAsync();

            var model = new PaginatedViewModel<Product>(pageIndex, pageSize, (int)totalProductCount, productsOnPage);

            return Ok(model);
        }

        [HttpGet]
        [Route("getSimilarProducts")]
        public async Task<IActionResult> SimilarProducts(int productId)
        {
            var product = _productContext.Products.FirstOrDefault(p => p.Id == productId);
            var similarProducts = await _productContext.Products.Include(p => p.Brand).Include(p => p.DownCategory).Include(p => p.UpCategory).Include(p => p.Pictures).Where(p => p.UpCategoryId == product.UpCategoryId).ToListAsync();
            similarProducts.Remove(product); 

            Random random = new Random();
            List<Product> selectedSimilarProducts = new List<Product>();

            if (similarProducts.Count>3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int randomIndex = random.Next(similarProducts.Count);
                    var selectedSimilarProduct = similarProducts[randomIndex];
                    selectedSimilarProducts.Add(selectedSimilarProduct);
                    similarProducts.Remove(selectedSimilarProduct);
                }
                return Ok(selectedSimilarProducts);
            }
            return Ok(similarProducts);

        }


        //----------------------------------------------------------------------------------------------------------
        [HttpPost]
        [Route("products/add")]
        public async Task<string> CreateProductAsync([FromBody] AddProduct newProduct /*Product productToCreate, IFormFile[] formFiles*//*, [FromForm(Name = "Image")] IFormFile file, [FromForm(Name = "Image1")] IFormFile file1, [FromForm(Name = "Image2")] IFormFile file2*/)
        {
            if (newProduct.Product.UpCategoryId > 0 && newProduct.Product.DownCategoryId > 0 && newProduct.Product.BrandId > 0)
            {
                var product = new Product
                {
                    Name = newProduct.Product.Name,
                    Price = Convert.ToDecimal(newProduct.Product.Price.ToString("N2")),
                    Description = newProduct.Product.Description,
                    BrandId = newProduct.Product.BrandId,
                    UpCategoryId = newProduct.Product.UpCategoryId,
                    DownCategoryId = newProduct.Product.DownCategoryId
                };

                _productContext.Products.Add(product);
                await _productContext.SaveChangesAsync();
                List<IFormFile> files = new List<IFormFile>();
                List<string> results = new List<string>();
                foreach (var byteFormFile in newProduct.ProductImageFiles)
                {
                    if (byteFormFile != null)
                    {
                        var stream = new MemoryStream(byteFormFile);
                        var formFile = new FormFile(stream, 0, byteFormFile.Length, "file", "file.jpg"); 
                        files.Add(formFile);
                    }
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


                return "Ürün Eklenildi.";
            }
            return "Kategori yada Markayla İlgili Bilgi Yanlış.";
        }


        [HttpDelete]
        [Route("products/delete/{id}")]
        public async Task<string> DeleteProductAsync(int id)
        {
            List<string> results = new List<string>();
            var product = _productContext.Products.Include(p=>p.Pictures).SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return $"{id} numaralı id'ye ait ürün bulunamadı.";
            }
            if (product.Pictures!=null)
            {
                for (int i = 0; i < product.Pictures.Count; i++)
                {
                    var result = await PictureManagement.Remove(product.Pictures[i].Id, product.Id, _productContext);
                    results.Add(result);
                }
            }
            _productContext.Products.Remove(product);
            await _productContext.SaveChangesAsync();
            foreach (var result in results)
            {
                if (result != "Ürün Resimi Silindi.")
                {
                    return "Resimleri silerken hata oluştu.Ama ürün silindi." ;
                }
            }
            return "Başarılı bir şekilde ürün silindi" ;
        }


        [HttpPost]
        [Route("products/update")]
        public async Task<string> UpdateProductAsync([FromBody]AddProduct productToUpdate)
        {
            var product = await _productContext.Products.SingleOrDefaultAsync(p => p.Id == productToUpdate.Product.Id);
            if (product == null)
            {
                return $"{productToUpdate.Product.Id} numaralı id'ye ait ürün bulunamadı.";
            }
            product.Name = productToUpdate.Product.Name;
            product.Price = productToUpdate.Product.Price;
            product.Description = productToUpdate.Product.Description;
            product.BrandId = productToUpdate.Product.BrandId;
            product.DownCategoryId = productToUpdate.Product.DownCategoryId;
            product.UpCategoryId = productToUpdate.Product.UpCategoryId;
            List<IFormFile> files = new List<IFormFile>();
            List<string> results = new List<string>();
            foreach (var byteFormFile in productToUpdate.ProductImageFiles)
            {
                if (byteFormFile != null)
                {
                    var stream = new MemoryStream(byteFormFile);
                    var formFile = new FormFile(stream, 0, byteFormFile.Length, "file", "file.jpg");
                    files.Add(formFile);
                }
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
            _productContext.Products.Update(product);
            await _productContext.SaveChangesAsync();
            return  "Ürün başarılı bir şekilde güncellenildi." ;
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
        [HttpPost]
        [Route("products/removeProductImage/{productId}")]
        public async Task<string> RemoveProductPicture([FromBody]string picturePath, int productId)
        {
            var picture = await _productContext.Pictures.SingleOrDefaultAsync(p => p.ProductId == productId && p.ImagePath==picturePath);
            if (picture == null)
            {
                return $"{productId} Id'ye ait {picturePath} fotoğrafı bulunamadı.";
            }
            var result = await PictureManagement.Remove(picture.Id, productId, _productContext);
            return result;
        }

        //----------------------------------------------------------------------------------------------------------

    }
}
