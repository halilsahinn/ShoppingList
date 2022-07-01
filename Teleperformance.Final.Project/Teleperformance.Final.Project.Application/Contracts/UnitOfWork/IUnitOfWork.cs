using Teleperformance.Final.Project.Application.Contracts.Repositories;

namespace Teleperformance.Final.Project.Application.Contracts.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }

        Task Save();

    }
}
