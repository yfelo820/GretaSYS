﻿using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    class CountryEntityConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ConfigurationBase<long, string, Country>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            //builder.Property(x => x.CountryId).HasColumnType("long").IsRequired();
            //builder.HasOne(x => x.City).WithMany(x => x.Cities).HasForeignKey(x => x.FamilyId).OnDelete(DeleteBehavior.Cascade);
            //builder.HasOne(x => x.CountryId).WithMany(x => x.Provinces).HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.Cascade);
            //builder.HasMany(x=>x.Cities).WithOne(x=>x.Id)

        }
    }
}
