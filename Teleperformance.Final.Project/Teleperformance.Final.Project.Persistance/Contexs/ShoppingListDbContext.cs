using Microsoft.EntityFrameworkCore;

namespace Teleperformance.Final.Project.Persistance.Contexs
{
    public class ShoppingListDbContext : DbContext
    {
        #region CTOR
        public ShoppingListDbContext(DbContextOptions options) : base(options)
        {
        }
        #endregion

        #region DBSET

        #endregion

        #region METHODS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion




    }
}
