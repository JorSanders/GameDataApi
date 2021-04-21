using Jorkol.GameDataApi.ApexLegends.Db;
using Jorkol.GameDataApi.ApexLegends.Mappers;
using Jorkol.GameDataApi.ApexLegends.Repositories;
using Jorkol.GameDataApi.ApexLegends.Services;
using Jorkol.GameDataApi.TrackerNetworkClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.OpenApi.Models;

namespace Jorkol.GameDataApi
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GameDataApi", Version = "v1" });
            });

            services.AddTransient<ITrackerNetworkApexClient>(s => new TrackerNetworkApexClient(Configuration["TrackerNetwork:ApiKey"]));

            services.AddDbContext<ApexDbContext>(options =>
                options.UseMySQL(Configuration["ConnectionString:GameApiDb"])
            // .UseLoggerFactory(new LoggerFactory(new[] {
            // new DebugLoggerProvider()}))
            // .EnableSensitiveDataLogging()
            );

            services.AddScoped<IApexMatchRepository, ApexMatchRepository>();
            services.AddScoped<IApexAccountRepository, ApexAccountRepository>();
            services.AddScoped<IApexCharacterRepository, ApexCharacterRepository>();
            services.AddScoped<IApexMatchService, ApexMatchService>();
            services.AddScoped<IApexMapper, ApexMapper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "GameDataApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
