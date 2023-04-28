using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebApplicationAdminPanel.Business.Abstract;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Helper;
using WebApplicationAdminPanel.Entity.Concrete.Product;
using WebApplicationAdminPanel.Extensions.ClientHttp;

namespace WebApplicationAdminPanel.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<PaginatedViewModel<Product>> GetProductsItem(int paginationNumber, int pageSize)
        {
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>($"/product/products?pageIndeX={paginationNumber}&pageSize={pageSize}");
            return products;
        }
        public async Task<List<Product>> GetProductItem(int productId)
        {
            var products = await _httpClient.GetResponseAsync<List<Product>>($"/product/products?ids={productId.ToString()}");
            return products;
        }

        public async Task<PaginatedViewModel<Product>> GetProductItemByUpCategories(UpCategory upCategory, int paginationNumber)
        {
            var productQuery = $"/product/products/upCategoryId/{upCategory.Id}?pageIndex={paginationNumber}";

            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(productQuery);

            return products;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItemByDownCategories(DownCategory downCategory, int paginationNumber)
        {
            var productQuery = $"/product/products/downCategoryId/{downCategory.Id}?pageIndex={paginationNumber}";

            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(productQuery);

            return products;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItemByBrands(Brand brand, int paginationNumber)
        {
            var productQuery = $"/product/products/BrandId/{brand.Id}?pageIndex={paginationNumber}";

            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(productQuery);

            return products;
        }

        public async Task<List<UpCategory>> GetUpCategoryItems()
        {
            List<UpCategory> upCategories = await _httpClient.GetResponseAsync<List<UpCategory>>("/UpCategory/upCategories");
            return upCategories;
        }
        public async Task<List<DownCategory>> GetDownCategoryItems()
        {
            List<DownCategory> downCategories = await _httpClient.GetResponseAsync<List<DownCategory>>("/DownCategory/downCategories");
            return downCategories;
        }
        public async Task<List<Brand>> GetBrandItems()
        {
            List<Brand> brands = await _httpClient.GetResponseAsync<List<Brand>>("/brand/brands");
            return brands;
        }

        private async Task<byte[]> GetFileBytesAsync(IBrowserFile formFile)
        {
            try
            {
                var buffer = new byte[16 * 1024]; // 16KB'lık bir buffer tanımlıyoruz.
                using (var ms = new MemoryStream())
                {
                    var stream = formFile.OpenReadStream();
                    int read;
                    while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        await ms.WriteAsync(buffer, 0, read);
                    }
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> AddProductItem(Product product, List<IBrowserFile> formFiles)
        {
            var productImageFiles = new List<byte[]>();
            foreach (var formFile in formFiles)
            {
                if (formFile != null && formFile.Size > 0)
                {
                    byte[] dizi = await GetFileBytesAsync(formFile);
                    productImageFiles.Add(dizi);
                }
            }
            var addProduct = new ProductDTO()
            {
                Product = product,
                ProductImageFiles = productImageFiles
            };
            var result = await _httpClient.PostGetStringResponseAsync<ProductDTO>("product/products/add", addProduct);
            return result;

        }

        public async Task<string> RemoveProductItem(int productId)
        {
            var result = await _httpClient.RemoveAsync("product/products/delete/"+ productId);
            return result;
        }

        public async Task<string> UpdateProductItem(ProductDTO productDto)
        {
            var result = await _httpClient.PostGetStringResponseAsync<ProductDTO>("product/products/update", productDto);
            return result;
        }

        public async Task<string> RemoveProductPicture(string picturePath, int productId)
        {
            var query = "product/products/removeProductImage/" + productId;
            var result = await _httpClient.PostGetStringResponseAsync<string>(query, picturePath);
            return result;
        }

    }
}
