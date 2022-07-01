using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Persistance.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<CategoryEntity>
    {
        #region CTOR

        public CategorySeed()
        {

        }

        #endregion

        #region CONFIGURE
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            builder.HasData(
                new CategoryEntity { Id = 1, CategoryName = "Alışveriş Listesi" },
                new CategoryEntity { Id = 2, CategoryName = "Film Listesi"},
                new CategoryEntity { Id = 3, CategoryName = "Yapılacaklar Listesi"}


                );
        }
        #endregion


    }
}
