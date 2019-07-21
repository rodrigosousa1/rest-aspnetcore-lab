﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestAspNetCoreLab.Model.Context;
using RestAspNetCoreLab.Repository;
using RestAspNetCoreLab.Repository.Implementations;
using RestAspNetCoreLab.Services;
using RestAspNetCoreLab.Services.Implementations;

namespace RestAspNetCoreLab
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
            services.AddDbContext<PgSQLContext>(options => options.UseNpgsql(Configuration.GetConnectionString("PgSqlConnectionString")));

            // Add framework services.
            services.AddMvc();

            services.AddApiVersioning();

            // Dependency Injection
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonRepository, PersonRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
