using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigurationBase<long, string, Category>();

            builder.Property(x => x.Name).HasColumnType("varchar(40)").IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();
            builder.Property(x => x.Description).HasColumnType("varchar(254)").IsRequired();

            builder.HasMany(x => x.Products);

            #region Seed

            var categories = new List<Category>();
            for (var i = 0; i < 100; i++)
            {
                var category = new Category()
                {
                    Id = i + 1,
                    Name = "Category " + i,
                    Description = "Description" + i,
                    UserCreatorId = Guid.NewGuid().ToString()
                };
                categories.Add(category);
            }

            builder.HasData(categories);

            #endregion Seed
        }
    }
}
