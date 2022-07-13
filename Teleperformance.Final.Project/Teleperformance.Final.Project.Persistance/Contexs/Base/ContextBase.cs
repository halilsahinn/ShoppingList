using Microsoft.EntityFrameworkCore;
using Teleperformance.Final.Project.Domain.Base;

namespace Teleperformance.Final.Project.Persistance.Contexs.Base
{
    public abstract class ContextBase : DbContext
    {
        #region SUMMARY
        /// <summary>
        /// Bu class contex save changes metodu tetiklendiğinde base entity'den miras alan 
        /// entity' lerin createdate ve updatedate leri savechanges metdou tetiklendiğinde otomatik setler.
        /// </summary>
        /// <param name="options">@options</param>
        #endregion

        #region CTOR
        public ContextBase(DbContextOptions options) : base(options)
        {
        }

        #endregion

        #region METHODS
        public virtual async Task<int> SaveChangesAsync()
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.UpdatedDate = DateTime.Now;


                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDate = DateTime.Now;

                }
            }

            var result = await base.SaveChangesAsync();

            return result;
        }

        #endregion


    }

}

