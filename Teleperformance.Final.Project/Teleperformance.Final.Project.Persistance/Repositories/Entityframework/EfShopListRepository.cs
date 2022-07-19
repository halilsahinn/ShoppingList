using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.ShopList;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfShopListRepository : GenericRepositoryBase<ShopListEntity>, IShopListRepository
    {
        private readonly ShoppingListDbContext _dbContext;
        public EfShopListRepository(ShoppingListDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ShopListEntity>> CompletedList()
        {
            var productList = GetAll().Result.ToList().Where(x => x.IsCompleted = true);

            return (List<ShopListEntity>)productList;
        }

        public async Task<ShopListEntity> CompleteShopList(int id)
        {
            var shopList = GetByPredicate(x => x.Id == id);
            shopList.IsCompleted = true;

            Update(shopList);

            return shopList;

        }
    }
}
