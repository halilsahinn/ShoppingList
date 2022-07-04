using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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


          

            builder.Property(p => p.CreatedDate).HasColumnName("CreateDate").HasColumnOrder(4);
            builder.Property(p => p.UpdatedDate).HasColumnName("UpatedDate").HasColumnOrder(5);

            builder.Property(p => p.Description).HasColumnName("Description").HasColumnOrder(8).HasMaxLength(500);
            builder.Property(p => p.IsActive).HasColumnName("IsActive").HasColumnOrder(9);

            #endregion

            #region RELATIONS



            #endregion

            #region TABLE & SCHEME

            builder.ToTable("Main", "ShopList");

            #endregion
        }
    }
}
