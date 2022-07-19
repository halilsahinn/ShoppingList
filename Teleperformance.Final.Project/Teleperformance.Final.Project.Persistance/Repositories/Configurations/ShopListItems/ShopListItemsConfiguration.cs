using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teleperformance.Final.Project.Domain.ShopListItems;

namespace Teleperformance.Final.Project.Persistance.Repositories.Configurations.ShopListItems
{
    public class ShopListItemsConfiguration : IEntityTypeConfiguration<ShopListItemsEntity>
    {
        public void Configure(EntityTypeBuilder<ShopListItemsEntity> builder)
        {
            #region PROPERTIES

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Id).HasColumnOrder(1);


            builder.Property(p => p.ShopListId).HasColumnOrder(2);
            builder.Property(p => p.ProductId).HasColumnOrder(3);


            builder.Property(p => p.CreatedDate).HasColumnName("CreateDate").HasColumnOrder(4);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(5);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(6).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(7);

            #endregion

            #region RELATIONS

            

            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Items", "ShopList");

            #endregion
        }
    }
}
