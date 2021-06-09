using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class DiscountEntityConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.ConfigurationBase<long, string, Discount>();

            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Value).IsRequired();

            builder.HasMany(x => x.StoreProducts);
        }
    }
}
