using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Persistance.Contexs;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base
{
    public class GenericRepositoryBase<T> : IGenericRepository<T> where T : class
    {
        private readonly ShoppingListDbContext _dbContext;
        protected DbSet<T> _dbSet => _dbContext.Set<T>();
        public GenericRepositoryBase(ShoppingListDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetById(id);
            return entity != null;
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public IQueryable<T> GetAllByIQueryable()
        {
          return  _dbSet.AsQueryable();
        }

        public IEnumerable<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            // _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public T GetByPredicate(Expression<Func<T, bool>> expression)
        {
            return _dbSet.SingleOrDefault(expression);
        }

     }
}
