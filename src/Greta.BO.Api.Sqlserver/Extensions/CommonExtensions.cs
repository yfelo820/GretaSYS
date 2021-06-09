using Greta.Sdk.Core.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Greta.BO.Api.Sqlserver.Extensions
{
    public static class CommonExtensions
    {

        /// <summary>
        /// Sets the traversal properties of an entity that implements the IEntityBase interface
        /// </summary>
        /// <typeparam name="TKey">Type of data that will identify the record</typeparam>
        /// <typeparam name="TUserKey">Type of data that the user will identify</typeparam>
        /// <typeparam name="TEntity">The entity type to be configured.</typeparam>
        /// <param name="userRequired"></param>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public static void ConfigurationLocalizationBase<TKey, TUserKey, TEntity>(this Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IEntityLocationBase<TKey, TUserKey>
        {
            builder.Property(x => x.Country).HasColumnType("varchar(30)");
            builder.Property(x => x.City).HasColumnType("varchar(20)");
            builder.Property(x => x.Province).HasColumnType("varchar(2)");
            builder.Property(x => x.Zip).HasColumnType("varchar(12)");
        }
    }
}
