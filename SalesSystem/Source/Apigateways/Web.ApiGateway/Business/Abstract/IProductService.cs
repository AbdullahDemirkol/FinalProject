using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ApiGateway.Entity.Concrete.Product;

namespace Web.ApiGateway.Business.Abstract
{
    public interface IProductService
    {
        Task<ProductItem> GetProductItemAsync(int id);
        Task<IEnumerable<ProductItem>> GetProductItemsAsync(IEnumerable<int> ids);
    }
}
