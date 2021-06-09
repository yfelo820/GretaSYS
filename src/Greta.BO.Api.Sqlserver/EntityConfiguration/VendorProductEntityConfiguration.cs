using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class VendorProductEntityConfiguration : IEntityTypeConfiguration<VendorProduct>
    {
        public void Configure(EntityTypeBuilder<VendorProduct> builder)
        {
            builder.ConfigurationBase<long, string, VendorProduct>();

            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.PackQty).IsRequired().HasDefaultValue<int>(0);
            builder.Property(x => x.IsPrimary).HasDefaultValue<bool>(false);
            builder.Property(x => x.ProductCode).IsRequired();

            builder.HasOne(x => x.Product).WithMany(x => x.VendorProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Vendor).WithMany(x => x.VendorProducts).HasForeignKey(x => x.VendorId);
        }
    }
}
