using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ScaleCategoryEntityConfiguration : IEntityTypeConfiguration<ScaleCategory>
    {
        public void Configure(EntityTypeBuilder<ScaleCategory> builder)
        {
            builder.ConfigurationBase<long, string, ScaleCategory>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasMany(x => x.ScaleProducts);
        }
    }
}
