using Greta.BO.Api.Entities;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Greta.BO.Api.Sqlserver.EntityConfiguration
{
    public class ScaleProductEntityConfiguration : IEntityTypeConfiguration<ScaleProduct>
    {
        public void Configure(EntityTypeBuilder<ScaleProduct> builder)
        {
            builder.ConfigurationBase<long, string, ScaleProduct>();

            builder.HasIndex(p => p.PLUNumber).IsUnique();

            builder.Property(x => x.Description1).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.Description2).HasColumnType("varchar(40)");
            builder.Property(x => x.Description3).HasColumnType("varchar(40)");

            builder.Property(x => x.Text1).HasColumnType("varchar(1000)");
            builder.Property(x => x.Text2).HasColumnType("varchar(1000)");
            builder.Property(x => x.Text3).HasColumnType("varchar(1000)");
            builder.Property(x => x.Text4).HasColumnType("varchar(1000)");

            builder.Property(x => x.Tare1).HasColumnType("numeric(18,2)");
            builder.Property(x => x.Tare2).HasColumnType("numeric(18,2)");

            builder.HasOne(x => x.ScaleCategory).WithMany(x => x.ScaleProducts).HasForeignKey(x => x.ScaleCategoryId).OnDelete(DeleteBehavior.Cascade).IsRequired();

            builder.HasOne(x => x.ScaleLabelType1).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ScaleLabelType2).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ScaleLabelType3).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ScaleLabelType4).WithMany().OnDelete(DeleteBehavior.NoAction);


            builder.Property(x => x.ServingPerContainer).HasColumnType("numeric(18,2)");
            builder.Property(x => x.ServingSize).HasColumnType("numeric(18,2)");
            builder.Property(x => x.AmountPerServingCalories).HasColumnType("numeric(18,2)");
            builder.Property(x => x.TotalFatGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.TotalFat).HasColumnType("numeric(18,2)");
            builder.Property(x => x.SaturedFatGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.SaturedFat).HasColumnType("numeric(18,2)");
            builder.Property(x => x.CholesterolMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.Cholesterol).HasColumnType("numeric(18,2)");
            builder.Property(x => x.SodiumMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.Sodium).HasColumnType("numeric(18,2)");
            builder.Property(x => x.TotalCarbohydrateGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.TotalCarbohydrate).HasColumnType("numeric(18,2)");
            builder.Property(x => x.DietaryFiberGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.DietaryFiber).HasColumnType("numeric(18,2)");
            builder.Property(x => x.TotalSugarGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.AddedSugarGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.AddedSugar).HasColumnType("numeric(18,2)");
            builder.Property(x => x.ProteinGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.VitDMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.VitD).HasColumnType("numeric(18,2)");
            builder.Property(x => x.CalciumMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.Calcium).HasColumnType("numeric(18,2)");
            builder.Property(x => x.IronMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.PotasMGrams).HasColumnType("numeric(18,2)");
            builder.Property(x => x.Potas).HasColumnType("numeric(18,2)");

        }
    }
}
