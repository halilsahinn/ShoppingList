using Teleperformance.Final.Project.Domain.Base;

namespace Teleperformance.Final.Project.Application.Contracts.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);


    }
}
