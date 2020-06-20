using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dynamics.Repository;
using Dynamics.Repository.Implementations;
using Dynamics.Repository.Interfaces;
using Dynamics.Service.Implementations;
using Dynamics.Service.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Dynamics.Api
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
                        services.AddCors();
            services.AddControllers();
            services.AddDbContextPool<DynamicsDbContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DynamicsConnections")));
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, GenericUnitOfWork>();

            services.AddScoped<IInvoiceManager, InvoiceManager>();
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IStoreManager, StoreManager>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.SetIsOriginAllowed(s => _ = true).AllowAnyHeader().AllowAnyMethod().AllowCredentials());

            //app.UseCors(builder =>
            //{
            //    builder.WithOrigins("http://localhost:4200")
            //    .AllowAnyHeader()
            //    .AllowAnyMethod()
            //    .AllowCredentials();
            //});

            //app.UseMvc();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
