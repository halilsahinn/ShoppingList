using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.Product;

namespace Teleperformance.Final.Project.Persistance.Repositories.Configurations.Product
{
    public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

          
            builder.Property(p => p.ProductName).ValueGeneratedOnAdd().HasColumnOrder(1);
            builder.Property(p => p.ProductName).HasColumnName("ProductName").HasColumnOrder(2).IsRequired().HasMaxLength(150);


            builder.Property(p => p.CreatedDate).HasColumnName("CreateDate").HasColumnOrder(4);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(5);
  
            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(8).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(9);

            #endregion

            #region RELATIONS

          

            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Product", "ShopList");

            #endregion
        }
    }
}
