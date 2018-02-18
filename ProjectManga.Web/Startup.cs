namespace ProjectManga.Web
{
    using System.IO;
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using ProjectManga.Domain.Download;
    using ProjectManga.Web.Filters;
    using ProjectManga.Web.Services;
    using Swashbuckle.AspNetCore.Swagger;
    using ProjectManga.Data.Download;
    using ProjectManga.Data.Download.SQLite;

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
            services.AddLogging();
            services.AddSingleton<IDownloadRequestService, DownloadRequestService>();
            services.AddScoped<LoggingActionFilter>();
            services.AddScoped<IDownloadRequestRepository, DownloadRequestRepository>();
            services.AddScoped<IDownloadRequestGateway, SQLiteDownloadRequestGateway>();

            services.AddMvc(c =>
            {
                c.Filters.AddService(typeof(LoggingActionFilter));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Project Manga WebApi", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "Api.xml");
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Project Manga WebApi");
            });

            app.UseMvc();
        }
    }
}