using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Greta.BO.Api.Sqlserver
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.RegisterEntityConfigurations<SqlServerContext>();
        }

        public DbSet<Store> Store { get; set; }
        public DbSet<StoreProduct> StoreProduct { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ScaleCategory> ScaleCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ScaleProduct> ScaleProduct { get; set; }
        public DbSet<KitProduct> KitProduct { get; set; }

        public DbSet<Tax> Tax { get; set; }
        public DbSet<Discount> Discount { get; set; }

        public DbSet<Family> Family { get; set; }
        public DbSet<VendorProduct> VendorProduct { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<ScaleLabelType> ScaleLabelType { get; set; }

        public ScaleBrand ScaleBrand { get; set; }
    }
}
