using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class StoreEntityConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.ConfigurationBase<long, string, Store>();

            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasMany(x => x.StoreProducts);
        }
    }
}
