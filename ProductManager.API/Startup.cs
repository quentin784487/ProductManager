﻿using Microsoft.EntityFrameworkCore;
using ProductManager.CORE.Domain;
using ProductManager.CORE.Domain.Ports;
using ProductManager.CORE.Domain.Ports.Incoming;
using ProductManager.CORE.Domain.Ports.Outgoing;
using ProductManager.CORE.Persistence;
using ProductManager.Infrastructure;

namespace Web.API
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
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddDbContext<ProductsManagerDbContext>(opts => opts.UseInMemoryDatabase("products_db"));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGetProducts, GetProductsAdapter>();
            services.AddScoped<IGetProductsDatabase, GetProductsDatabaseAdapter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
