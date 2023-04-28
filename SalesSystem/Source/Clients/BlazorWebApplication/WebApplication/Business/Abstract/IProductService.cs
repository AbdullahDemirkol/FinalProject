using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entity.Concrete.Helper;
using WebApplication.Entity.Concrete.Product;

namespace WebApplication.Business.Abstract
{
    public interface IProductService
    {
        Task<PaginatedViewModel<Product>> GetProductsItem(int paginationNumber,int? pageSize);
        //Task<PaginatedViewModel<Product>> GetProductItem(string productId);
        Task<List<Product>> GetProductItem(int productId);
        Task<List<UpCategory>> GetUpCategoryItems();
        Task<List<DownCategory>> GetDownCategoryItems();
        Task<List<Brand>> GetBrandItems();
        Task<PaginatedViewModel<Product>> GetProductItemByUpCategories(UpCategory upCategory, int paginationNumber, int? pageSize);
        Task<PaginatedViewModel<Product>> GetProductItemByDownCategories(DownCategory downCategory, int paginationNumber, int? pageSize);
        Task<PaginatedViewModel<Product>> GetProductItemByBrands(Brand brand, int paginationNumber, int? pageSize);
    }
}
