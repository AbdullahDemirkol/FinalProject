using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebApplication.Business.Abstract;
using WebApplication.Entity.Concrete.Helper;
using WebApplication.Entity.Concrete.Product;
using WebApplication.Extensions.ClientHttp;

namespace WebApplication.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItem(int paginationNumber)
        {
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>($"/product/products?pageIndeX={paginationNumber}");
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
    }
}
