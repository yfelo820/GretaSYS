using Greta.BO.BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Greta.BO.BusinessLogic.Extensions
{
    public static class BusinessLogicExtensions
    {

        /// <summary>
        /// Gets all repositories and registers them in the.net core dependency container
        /// </summary>
        /// <typeparam name="TKey">Type of data that will identify the record</typeparam>
        /// <typeparam name="TUserKey">Type of data that the user will identify</typeparam>
        /// <typeparam name="TContext">Represents a session with the database and can be used to query and save instances of your entities</typeparam>
        /// <param name="services">The IServiceCollection to add services to.</param>
        public static void AddBLServices<TContext>(this IServiceCollection services)
        //where TContext : DbContext
        {
            var assembly = typeof(TContext).GetTypeInfo().Assembly;

            var @types = assembly.GetTypes().Where(x => !x.IsNested && !x.IsInterface && typeof(IBaseService).IsAssignableFrom(x));

            foreach (var type in @types)
            {
                var @interface = type.GetInterface($"I{type.Name}", false);

                services.AddTransient(@interface, type);
            }
        }
    }
}
