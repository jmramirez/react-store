using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ReactStore.API.Extensions;
using ReactStore.Domain.Extensions;
using ReactStore.Domain.Repositories;
using ReactStore.Domain.Responses;
using ReactStore.Infrastructure.Extensions;
using ReactStore.Infrastructure.Repositories;
using Stripe;

namespace ReactStore.API
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

            services.AddAppDbContext(Configuration.GetConnectionString("ConnectionString"));
            /*services.AddAppDbContext(Configuration.GetSection("DataSource:ConnectionString").Value);*/
            services.AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<IBrandRepository, BrandRepository>()
                .AddScoped<IColorRepository, ColorRepository>()
                .AddScoped<IOSRepository, OSRepository>()
                .AddScoped<IFeatureRepository, FeatureRepository>()
                .AddScoped<IStorageRepository, StorageRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IOrderRepository, OrderRepository>();
            services.AddMappers()
                .AddServices();

            services
                .AddTokenAuthentication(Configuration);
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ReactStore.API", Version = "v1" });
            });

            services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
                  builder
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .WithOrigins(Configuration["Frontend"])));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ReactStore.API v1"));
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            StripeConfiguration.ApiKey =
                "sk_test_51JSqRkHyqUWXkZvhMdMlr2Of4LCkKSkz0Jk9Fmm2oqptjI2cEeKJZyQQRaFscIsyfrbwVv43D0oWpeT9oKWHiOmP00kJRSQjJW";
        }
    }
}
