using Greta.BO.Api.Entities;
using Greta.BO.Api.Sqlserver;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Greta.BO.InMemory
{
    public class GretaBOContextInMemory : BaseContext
    {
        public GretaBOContextInMemory([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RegisterEntityConfigurations<GretaBOContextInMemory>();
        }

        public DbSet<Family> Family { get; set; }
    }
}
