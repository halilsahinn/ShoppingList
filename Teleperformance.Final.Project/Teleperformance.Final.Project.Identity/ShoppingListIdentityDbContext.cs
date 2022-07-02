using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Teleperformance.Final.Project.Identity.Configurations;
using Teleperformance.Final.Project.Identity.Models;

namespace Teleperformance.Final.Project.Identity
{
    public class ShoppingListIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        #region CTOR
        public ShoppingListIdentityDbContext(DbContextOptions<ShoppingListIdentityDbContext> options)
                  : base(options)
        {
        }

        #endregion

        #region METHODS
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
        #endregion

    }
}
