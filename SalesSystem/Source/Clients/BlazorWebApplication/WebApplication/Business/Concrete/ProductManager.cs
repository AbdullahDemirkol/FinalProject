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
        public async Task<PaginatedViewModel<Product>> GetProductsItem(int paginationNumber, int upCategoryId, int downCategoryId, int brandId, int? pageSize)
        {
            var query = $"/product/products?upCategoryId={upCategoryId}&downCategoryId={downCategoryId}&brandId={brandId}&pageIndeX={paginationNumber}";
            if (pageSize!=null)
            {
                query += $"&pageSize={pageSize}";
            }
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(query);
            return products;
        }
        public async Task<PaginatedViewModel<Product>> GetSearchProductsItem(int paginationNumber, string searchText)
        {
            var query = $"/product/products/Search?pageIndeX={paginationNumber}&searchText={searchText}";
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(query);
            return products;
        }
        public async Task<List<Product>> GetProductItem(int productId)
        {
            var product = await _httpClient.GetResponseAsync<List<Product>>($"/product/products?ids={productId}");
            return product;
        }

        public async Task<List<Product>> GetSimilarProductsItem(int productId)
        {
            var product = await _httpClient.GetResponseAsync<List<Product>>($"/product/getSimilarProducts?productId={productId}");
            return product;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItemByUpCategories(UpCategory upCategory, int paginationNumber, int? pageSize)
        {
            var productQuery = $"/product/products/upCategoryId/{upCategory.Id}?pageIndex={paginationNumber}";
            if (pageSize.HasValue)
            {
                productQuery += "&pageSize=" + pageSize;
            }
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(productQuery);

            return products;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItemByDownCategories(DownCategory downCategory, int paginationNumber,int? pageSize)
        {
            var productQuery = $"/product/products/downCategoryId/{downCategory.Id}?pageIndex={paginationNumber}";
            if (pageSize.HasValue)
            {
                productQuery += "&pageSize=" + pageSize;
            }
            var products = await _httpClient.GetResponseAsync<PaginatedViewModel<Product>>(productQuery);

            return products;
        }
        public async Task<PaginatedViewModel<Product>> GetProductItemByBrands(Brand brand, int paginationNumber, int? pageSize)
        {
            var productQuery = $"/product/products/BrandId/{brand.Id}?pageIndex={paginationNumber}";
            if (pageSize.HasValue)
            {
                productQuery += "&pageSize=" + pageSize;
            }
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
            var query = "/DownCategory/downCategories";
            List<DownCategory> downCategories = await _httpClient.GetResponseAsync<List<DownCategory>>(query);
            return downCategories;
        }
        public async Task<List<Brand>> GetBrandItems()
        {
            List<Brand> brands = await _httpClient.GetResponseAsync<List<Brand>>("/brand/brands");
            return brands;
        }

    }
}
