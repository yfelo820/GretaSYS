using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class StoreProductEntityConfiguration : IEntityTypeConfiguration<StoreProduct>
    {
        public void Configure(EntityTypeBuilder<StoreProduct> builder)
        {
            builder.ConfigurationBase<long, string, StoreProduct>();

            builder.Property(x => x.Price).HasColumnType("numeric(18,2)").IsRequired();
            builder.Property(x => x.Cost).HasColumnType("numeric(18,2)").IsRequired();
            builder.Property(x => x.GrossProfit).HasColumnType("numeric(18,2)");

            builder.HasOne(x => x.Store).WithMany(s => s.StoreProducts).HasForeignKey(sp => sp.StoreId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Product).WithMany(s => s.StoreProducts).HasForeignKey(sp => sp.ProductId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(x => x.Taxs);
            builder.HasMany(x => x.Discounts);
        }
    }
}
