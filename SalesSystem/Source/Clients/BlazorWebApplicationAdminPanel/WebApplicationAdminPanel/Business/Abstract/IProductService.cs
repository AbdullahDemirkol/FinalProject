using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Helper;
using WebApplicationAdminPanel.Entity.Concrete.Product;

namespace WebApplicationAdminPanel.Business.Abstract
{
    public interface IProductService
    {
        Task<PaginatedViewModel<Product>> GetProductsItem(int paginationNumber,int pageSize);
        Task<List<Product>> GetProductItem(int productId);
        Task<List<UpCategory>> GetUpCategoryItems();
        Task<List<DownCategory>> GetDownCategoryItems();
        Task<List<Brand>> GetBrandItems();
        Task<PaginatedViewModel<Product>> GetProductItemByUpCategories(UpCategory upCategory, int paginationNumber);
        Task<PaginatedViewModel<Product>> GetProductItemByDownCategories(DownCategory downCategory, int paginationNumber);
        Task<PaginatedViewModel<Product>> GetProductItemByBrands(Brand brand, int paginationNumber);
        Task<string> AddProductItem(Product product, List<IBrowserFile> formFiles);
        Task<string> UpdateProductItem(ProductDTO productDto);
        Task<string> RemoveProductItem(int productId);
        Task<string> RemoveProductPicture(string picturePath, int productId);
    }
}
