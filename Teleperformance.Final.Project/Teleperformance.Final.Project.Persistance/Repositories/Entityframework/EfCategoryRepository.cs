using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Domain.Category;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework.Base;

namespace Teleperformance.Final.Project.Persistance.Repositories.Entityframework
{
    public class EfCategoryRepository : GenericRepositoryBase<CategoryEntity>, ICategoryRepository
    {
         
        private readonly ShoppingListDbContext _dbContext;

        public EfCategoryRepository(ShoppingListDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
