using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ConfigurationBase<long, string, Employee>();

            builder.Property(x => x.LastName).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.FirstName).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.Address1).HasColumnType("varchar(80)").IsRequired();
            builder.Property(x => x.Address2).HasColumnType("varchar(80)").IsRequired();
            builder.Property(x => x.Zip).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.Phone).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("varchar(40)").IsRequired();           

            
        }

    }
}
