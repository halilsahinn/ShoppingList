using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.ShopListItems;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfShopListItemsRepository : GenericRepositoryBase<ShopListItemsEntity>, IShopListItemsRepository
    {
        private readonly ShoppingListDbContext _dbContext;

        public EfShopListItemsRepository(ShoppingListDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
