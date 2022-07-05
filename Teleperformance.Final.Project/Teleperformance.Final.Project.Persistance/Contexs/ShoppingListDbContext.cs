using Microsoft.EntityFrameworkCore;
using Teleperformance.Final.Project.Domain.Category;
using Teleperformance.Final.Project.Domain.Product;
using Teleperformance.Final.Project.Domain.ShopList;
using Teleperformance.Final.Project.Persistance.Contexs.Base;

namespace Teleperformance.Final.Project.Persistance.Contexs
{
    public class ShoppingListDbContext : ContextBase
    {
        #region CTOR

        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options)
        {

        }
        

        #endregion

        #region DBSET

        public DbSet<ShopListEntity> ShoppingList { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        #endregion

        #region METHODS
        /// <summary>
        /// Con
        /// </summary>
        /// <param name="modelBuilder">@modelBuilder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShoppingListDbContext).Assembly);
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
        }

        #endregion


    }
}
