using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Application.Contracts.Repositories
{
    public interface IShopListRepository : IGenericRepository<ShopListEntity>
    { 
        Task<List<ShopListEntity>> CompletedList();
        Task<ShopListEntity> CompleteShopList(int id);

    }
}
