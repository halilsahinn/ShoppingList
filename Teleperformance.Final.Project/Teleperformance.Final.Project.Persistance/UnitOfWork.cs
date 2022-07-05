using Teleperformance.Final.Project.Application.Contracts.Repositories;
using Teleperformance.Final.Project.Application.Contracts.UnitOfWork;
using Teleperformance.Final.Project.Persistance.Contexs;
using Teleperformance.Final.Project.Persistance.Repositories.Entityframework;

namespace Teleperformance.Final.Project.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {

        #region FIELDS
        private readonly ShoppingListDbContext _context;

        private IProductRepository _productRepository;
        private ICategoryRepository _categoryRepository;
        private IShopListRepository _shopListRepository;
        #endregion

        #region CTOR
        public UnitOfWork(ShoppingListDbContext context)
        {
            _context = context;
        }
        #endregion

        #region INTERFACES
        public IProductRepository ProductRepository =>
        _productRepository ??= new EfProductRepository(_context);

        public ICategoryRepository CategoryRepository =>
            _categoryRepository ??= new EfCategoryRepository(_context);

        public IShopListRepository ShopListRepository =>
           _shopListRepository ??= new EfShopListRepository(_context);

        #endregion
 
        #region METHODS
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

    }
}
