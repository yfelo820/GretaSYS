using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class KitProductEntityConfiguration : IEntityTypeConfiguration<KitProduct>
    {
        public void Configure(EntityTypeBuilder<KitProduct> builder)
        {
            builder.ConfigurationBase<long, string, KitProduct>();

            builder
                .HasMany(x => x.Products)
                .WithMany(p => p.KitProducts)
                .UsingEntity<KitProductProduct>(
                bg => bg.HasOne(kp => kp.Product)
                    .WithMany()
                    .HasForeignKey(kp => kp.ProductId).OnDelete(DeleteBehavior.NoAction),
                bg => bg
                    .HasOne(bg => bg.KitProduct)
                    .WithMany()
                    .HasForeignKey(kp => kp.KitProductId).OnDelete(DeleteBehavior.NoAction))
                .ToTable("KitProductProduct")
                .HasKey(bg => new { bg.ProductId, bg.KitProductId });
        }
    }
}
