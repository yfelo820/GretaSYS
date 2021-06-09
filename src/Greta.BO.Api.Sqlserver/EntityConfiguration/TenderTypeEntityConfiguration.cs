using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class TenderTypeEntityConfiguration : IEntityTypeConfiguration<TenderType>
    {
        public void Configure(EntityTypeBuilder<TenderType> builder)
        {
            builder.ConfigurationBase<long, string, TenderType>();

            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();
            builder.Property(x => x.OpenDrawer).HasDefaultValue<bool>(false);
            builder.Property(x => x.DisplayAs).HasColumnType("varchar(64)").IsRequired();


        }
    }
}
