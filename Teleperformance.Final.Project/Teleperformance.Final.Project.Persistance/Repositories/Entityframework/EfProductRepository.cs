using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.Product;
using Teleperformance.Final.Project.Persistance.Contexs;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfProductRepository : GenericRepository<ProductEntity>, IProductRepository
    {
        private readonly ShoppingListDbContext _dbContext;

        public EfProductRepository(ShoppingListDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }






    }
}
