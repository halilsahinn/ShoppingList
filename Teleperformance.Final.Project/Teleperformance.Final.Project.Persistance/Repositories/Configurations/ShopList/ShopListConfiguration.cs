using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.Category;
using Teleperformance.Final.Project.Domain.ShopList;

namespace Teleperformance.Final.Project.Persistance.Repositories.Configurations.ShopList
{
    public class ShopListConfiguration : IEntityTypeConfiguration<ShopListEntity>
    {
        public void Configure(EntityTypeBuilder<ShopListEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnOrder(1);

            builder.Property(p => p.Title).HasColumnName("Title").HasColumnOrder(2).HasMaxLength(500);
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId").HasColumnOrder(3).IsRequired(true);
            
            builder.Property(p => p.UserId).HasColumnName("UserId").HasColumnOrder(4).IsRequired(true);

            builder.Property(p => p.IsCompleted).HasColumnName("IsCompleted").HasColumnOrder(5);

            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").HasColumnOrder(6);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(7).IsRequired(false);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(8).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(9);

            #endregion

            #region RELATIONS

            //builder.HasOne(e => e.Category).WithMany(); 
            //builder.HasMany(e => e.Products);

            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Main", "ShopList");

            #endregion
        }
    }
}
