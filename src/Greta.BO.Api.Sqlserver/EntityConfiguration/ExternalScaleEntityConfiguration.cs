using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ExternalScaleEntityConfiguration : IEntityTypeConfiguration<ExternalScale>
    {
        public void Configure(EntityTypeBuilder<ExternalScale> builder)
        {
            builder.ConfigurationBase<long, string, ExternalScale>();

            builder.Property(x => x.Ip).HasColumnType("varchar(64)").IsRequired();
            builder.Property(x => x.Port).HasColumnType("varchar(64)").IsRequired();

            builder.HasOne(x => x.ScaleBrand).WithMany(x => x.ExternalScales).HasForeignKey(x => x.ScaleBrandId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.Store).WithMany(x => x.ExternalScales).HasForeignKey(x => x.StoreId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
