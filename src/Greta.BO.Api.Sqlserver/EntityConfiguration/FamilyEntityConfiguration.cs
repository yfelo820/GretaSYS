using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class FamilyEntityConfiguration : IEntityTypeConfiguration<Family>
    {
        public void Configure(EntityTypeBuilder<Family> builder)
        {
            builder.ConfigurationBase<long, string, Family>();

            builder.Property(x => x.Name).HasColumnType("varchar(64)").IsRequired();

            builder.HasMany(x => x.Discounts);
            builder.HasMany(x => x.Products);

            var families = new List<Family>();
            for (var i = 0; i < 100; i++)
            {
                var family = new Family()
                {
                    Id = i + 1,
                    Name = "Family " + i,
                    UserCreatorId = Guid.NewGuid().ToString()
                };
                families.Add(family);
            }

            builder.HasData(families);
        }
    }
}
