using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver.Extensions;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class VendorEntityConfiguration : IEntityTypeConfiguration<Vendor>
    {

        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ConfigurationBase<long, string, Vendor>();

            builder.ConfigurationLocalizationBase<long, string, Vendor>();

            builder.Property(x => x.Name).HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Contact).HasColumnType("varchar(30)");

            builder.Property(x => x.Phone).HasColumnType("varchar(14)");
            builder.Property(x => x.Email).HasColumnType("varchar(60)");
            builder.Property(x => x.Note).HasColumnType("varchar(254)");
            builder.Property(x => x.MinimalOrder).HasColumnType("numeric(15,3)");

            builder.HasMany(x => x.VendorProducts);

            var vendors = new List<Vendor>();
            for (var i = 0; i < 100; i++)
            {
                var vendor = new Vendor()
                {
                    Id = i + 1,
                    Name = "Vendor " + i,
                    Contact = "Create - Contact Vendor",
                    Phone = "1234567890",
                    Email = "test@test.com",
                    Note = "Note",
                    MinimalOrder = 200,
                    UserCreatorId = Guid.NewGuid().ToString()
                };
                vendors.Add(vendor);
            }

            builder.HasData(vendors);

        }
    }
}
