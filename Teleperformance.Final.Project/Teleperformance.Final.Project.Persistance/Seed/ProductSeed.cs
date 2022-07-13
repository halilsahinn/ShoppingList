using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Persistance.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<ProductEntity>
    {

        #region CTOR

        public ProductSeed()
        {

        }

        #endregion

        #region CONFIGURE
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasData(
                new ProductEntity { Id = 1, ProductName = "Süt", Unit = 1,CategoryId=1, Description = "" },
                new ProductEntity { Id = 2, ProductName = "Çikolata", Unit = 2 , CategoryId = 1, Description = "" },
                new ProductEntity { Id = 3, ProductName = "Gazoz", Unit = 3 , CategoryId = 1, Description = "" }


                );
        }
        #endregion



    }
}
