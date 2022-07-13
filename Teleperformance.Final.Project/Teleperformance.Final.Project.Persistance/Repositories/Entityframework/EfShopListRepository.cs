using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.ShopList;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfShopListRepository : GenericRepositoryBase<ShopListEntity>, IShopListRepository
    {
        private readonly ShoppingListDbContext _dbContext;
        public EfShopListRepository(ShoppingListDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
