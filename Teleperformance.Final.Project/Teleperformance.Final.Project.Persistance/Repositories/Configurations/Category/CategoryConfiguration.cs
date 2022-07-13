using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.Category;

namespace Teleperformance.Final.Project.Persistance.Repositories.Configurations.Category
{
    public class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnOrder(1);

       
            builder.Property(p => p.CategoryName).HasColumnName("CategoryName").HasColumnOrder(2).IsRequired().HasMaxLength(150);


            builder.Property(p => p.CreatedDate).HasColumnName("CreateDate").HasColumnOrder(3);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(4);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(5).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(6);

            #endregion

            #region RELATIONS

            builder.HasMany(p => p.Products).WithOne(c => c.Category).HasForeignKey(p => p.CategoryId);

            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Category", "ShopList");

            #endregion
        }
    }
}
