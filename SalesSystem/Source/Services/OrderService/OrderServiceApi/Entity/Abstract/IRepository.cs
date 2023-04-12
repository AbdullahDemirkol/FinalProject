using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Abstract
{
    public interface IRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
