using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ScaleBrandEntityConfiguration : IEntityTypeConfiguration<ScaleBrand>
    {
        public void Configure(EntityTypeBuilder<ScaleBrand> builder)
        {
            builder.ConfigurationBase<long, string, ScaleBrand>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}
