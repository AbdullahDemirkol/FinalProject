using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Helper
{
    public class PaginatedViewModel<TEntity> where TEntity : class, new()
    {
        public PaginatedViewModel(int pageIndex, int pageSize, int count, IEnumerable<TEntity> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            Data = data;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IEnumerable<TEntity> Data { get; set; }
    }
}
