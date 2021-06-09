using AutoMapper;
using Greta.BO.Api.Filters;
using Greta.BO.Api.Sqlserver;
using Greta.BO.BusinessLogic.Extensions;
using Greta.BO.BusinessLogic.Interfaces;
using Greta.BO.BusinessLogic.Service;
using Greta.Sdk.EFCore.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

namespace Greta.BO.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowSpecificOrigins",
                builder =>
                {
                    options.AddDefaultPolicy(builder =>
                   {
                       builder.AllowAnyOrigin()
                              .AllowAnyMethod()
                              .AllowAnyHeader()
                              .SetIsOriginAllowed(isOriginAllowed: _ => true);

                   });
                });
            });

            services.AddControllers(opt =>
            {
                opt.Filters.Add<GlobalExceptionFilter>();
            });

            services.AddAutoMapper(typeof(Startup));

            AddDBContext(services);

            this.AddSwagger(services);

            services.AddEFCore(this.Configuration)
                .AddIdentityService<string>()
                .AddRepositories<long, String, SqlServerContext>();
            services.AddBLServices<IBaseService>();            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseRouting();
            app.UseCors();
            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Greta.BO.Api");
            });


            app.UseAuthorization();
            app.UseIdentityService<string>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddDBContext(IServiceCollection services)
        {
            services.AddDbContext<SqlServerContext>(opt =>
            {
                if (!opt.IsConfigured)
                {
                    opt.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"), sqlopt =>
                    {
                        sqlopt.MigrationsAssembly(typeof(Startup).GetTypeInfo().Assembly.GetName().Name);
                        sqlopt.EnableRetryOnFailure(maxRetryCount: 10, maxRetryDelay: TimeSpan.FromSeconds(10), errorNumbersToAdd: null);
                    });
                }
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var version = "v1";

                options.SwaggerDoc(version, new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = $"Greta.BO.Api {version}",
                    Description = "Greta BO Api",
                    Version = version,
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Name = "Greta.BO",
                        Email = "chenryhabana205@gmail.com"
                    }
                });
            });
        }
    }
}
