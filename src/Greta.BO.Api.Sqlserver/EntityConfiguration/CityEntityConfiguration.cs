using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ConfigurationBase<long, string, City>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(x => x.ProvinceId).HasColumnType("long").IsRequired();
            //builder.HasOne(x => x.Province).WithMany(x => x.Provi).HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.Cascade);
            //builder.HasOne(x => x.ProvinceId).WithMany(x => x.).HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
