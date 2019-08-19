using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace insurance_policy.api
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
            services.AddMvc();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Insurance API by Daniel", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "insurance-policy.api.xml");
                c.IncludeXmlComments(xmlPath);
            });

            #region Dependency Container
            string connection = Configuration.GetValue<string>("ConnectionStrings:ConnectionString");
            
            //services.AddScoped(p => new FuelManagementContext(connection));
            //services.AddScoped<IVehiclesRepository, VehiclesRepository>();
            //services.AddScoped<IFuelFallsRepository, FuelFallsRepository>();
            //services.AddScoped<IFuelIncreasesRepository, FuelIncreasesRepository>();
            //services.AddScoped<IFuelPerformanceRepository, FuelPerformanceRepository>();
            //services.AddScoped<IRatingRepository, RatingRepository>();
            //services.AddScoped<IAnnotationRepository, AnnotationRepository>();
            //services.AddScoped<ITankDetailRepository, TankDetailRepository>();
            //services.AddScoped<IRepository>(q => new ConsumptionApproximateSettingsRepository(storageConnection, tableNameEvent));
            //services.AddScoped<IConsumptionApproximateReportRepository>(x => consumptionApproximateReportRepository);
            //services.AddScoped<IConsumptionApproximateSettingsService, ConsumptionApproximateSettingsService>();

            //services.AddScoped<IVehicleService, VehicleService>();
            //services.AddScoped<IFuelService, FuelService>();
            //services.AddScoped<IFallService, FallService>();
            //services.AddScoped<IIncreaseService, IncreaseService>();
            //services.AddScoped<ITankService, TankService>();
            //services.AddScoped<IConsumptionApproximateReportService>(x => new ConsumptionApproximateReportService(consumptionApproximateReportRepository, new ConsumptionApproximateSettingsService(new ConsumptionApproximateSettingsRepository(storageConnection, tableNameEvent))));

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("MyPolicy");

            //Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            //Enable middleware to serve swagger - ui(HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Insurance API V1");
                c.RoutePrefix = "swagger";
            });

            app.UseMvc();
        }
    }
}
