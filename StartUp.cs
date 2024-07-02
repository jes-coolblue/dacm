using Microsoft.OpenApi.Models;
using DACM.Services;
using DACM.Repositories;
using DACM.Cache;

namespace DACM
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();

			// Register the Swagger generator, defining one or more Swagger documents
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "Content Distribution API", Version = "v1" });
			});

			services.AddScoped<IAssetService, AssetService>();
			services.AddScoped<ICacheService, CacheService>();
			services.AddScoped<IRepository, Repository>();
			
			// Add memory cache
			services.AddMemoryCache();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				// Enable middleware to serve generated Swagger as a JSON endpoint
				app.UseSwagger();
				// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Content Distribution API v1"));
			}

			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}