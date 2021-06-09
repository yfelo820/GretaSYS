using Greta.BO.Api.Entities;
using Greta.BO.Api.Entities.Enum;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigurationBase<long, string, Product>();


            //builder.HasDiscriminator<ProductType>("ProductType")
            builder.HasDiscriminator(b => b.ProductType)
                .HasValue<Product>(ProductType.SPT)
                .HasValue<ScaleProduct>(ProductType.SLP)
                .HasValue<KitProduct>(ProductType.KPT)
                .IsComplete(false);

            builder.Property(x => x.UPC).HasColumnType("varchar(254)").IsRequired();
            builder.HasIndex(p => p.UPC).IsUnique();
            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(x => x.Description).HasColumnType("varchar(254)");


            builder.Property(x => x.QtyHand).HasColumnType("numeric(18,2)");
            builder.Property(x => x.OrderTrigger).HasColumnType("numeric(18,2)");
            builder.Property(x => x.OrderAmount).HasColumnType("numeric(18,2)");


            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Family).WithMany(x => x.Products).HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
