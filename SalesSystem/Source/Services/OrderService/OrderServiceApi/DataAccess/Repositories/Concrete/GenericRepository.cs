using Microsoft.EntityFrameworkCore;
using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Abstract;
using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly OrderDbContext _orderDbContext;

        public GenericRepository(OrderDbContext orderContext)
        {
            _orderDbContext = orderContext ?? throw new ArgumentNullException(nameof(orderContext));
        }

        public IUnitOfWork UnitOfWork => _orderDbContext;

        public T Add(T entity)
        {
             _orderDbContext.Add(entity);
            return entity;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _orderDbContext.AddAsync(entity);
            return entity;
        }

        public virtual async Task<List<T>> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> queryable = _orderDbContext.Set<T>();
            foreach (Expression<Func<T, object>> include in includes)
            {
                queryable = queryable.Include(include);
            }
            if (filter != null)
            {
                queryable = queryable.Where(filter);
            }
            if (orderBy != null)
            {
                queryable = orderBy(queryable);
            }
            return await queryable.ToListAsync();
        }

        public virtual Task<List<T>> Get( Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            return Get(filter, null, includes);
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _orderDbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await _orderDbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<T> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> queryable = _orderDbContext.Set<T>();
            foreach (Expression<Func<T, object>> include in includes)
            {
                queryable = queryable.Include(include);
            }
            return await queryable.FirstOrDefaultAsync(i => i.Id == id);

        }

        public virtual async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> queryable = _orderDbContext.Set<T>();
            foreach (Expression<Func<T, object>> include in includes)
            {
                queryable = queryable.Include(include);
            }
            return await queryable.Where(expression).FirstOrDefaultAsync();
        }

        public virtual T Update(T entity)
        {
            _orderDbContext.Set<T>().Update(entity);
            return entity;
        }
        public async virtual Task<T> UpdateAsync(T entity)
        {
            await _orderDbContext.AddAsync(entity);
            return entity;
        }
        public void Remove(T entity)
        {
            _orderDbContext.Set<T>().Remove(entity);
        }

    }
}
