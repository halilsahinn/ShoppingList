using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.Category;
using Teleperformance.Final.Project.Persistance.Contexs;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfCategoryRepository : GenericRepository<CategoryEntity>, ICategoryRepository
    {
         
        private readonly ShoppingListDbContext _dbContext;

        public EfCategoryRepository(ShoppingListDbContext dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
