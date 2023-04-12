using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.Helper;
using WebApplicationAdminPanel.Entity.Concrete.Product;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IProductService
    {
        Task<PaginatedViewModel<Product>> GetProductItem(int paginationNumber);
        Task<List<UpCategory>> GetUpCategoryItems();
        Task<List<DownCategory>> GetDownCategoryItems();
        Task<List<Brand>> GetBrandItems();
        Task<PaginatedViewModel<Product>> GetProductItemByUpCategories(UpCategory upCategory, int paginationNumber);
        Task<PaginatedViewModel<Product>> GetProductItemByDownCategories(DownCategory downCategory, int paginationNumber);
        Task<PaginatedViewModel<Product>> GetProductItemByBrands(Brand brand, int paginationNumber);
    }
}
