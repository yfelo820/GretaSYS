using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ScaleLabelTypeEntityConfiguration : IEntityTypeConfiguration<ScaleLabelType>
    {
        public void Configure(EntityTypeBuilder<ScaleLabelType> builder)
        {
            builder.ConfigurationBase<long, string, ScaleLabelType>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}