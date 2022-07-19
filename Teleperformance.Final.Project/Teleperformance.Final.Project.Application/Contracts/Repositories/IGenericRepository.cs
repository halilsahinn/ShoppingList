using System.Linq.Expressions;

namespace Teleperformance.Final.Project.Application.Contracts.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> GetById(int id);
        IEnumerable<T> GetBy(Expression<Func<T, bool>> expression);
        T GetByPredicate(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        IQueryable<T> GetAllByIQueryable();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);


    }
}
