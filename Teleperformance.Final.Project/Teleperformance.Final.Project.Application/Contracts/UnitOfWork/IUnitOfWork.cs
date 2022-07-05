using Teleperformance.Final.Project.Application.Contracts.Repositories;

namespace Teleperformance.Final.Project.Application.Contracts.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }

        IShopListRepository ShopListRepository { get; }

        Task Save();

    }
}
