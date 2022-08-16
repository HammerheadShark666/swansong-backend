using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwanSong.Api.Helpers.Extensions;
using SwanSong.Api.Middleware;
using SwanSong.Data;

namespace SwanSong.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
         
        public void ConfigureServices(IServiceCollection services)
        {           
            services.ConfigureMvc();
            services.ConfigureDbContext(Configuration);
            services.ConfigureCors();
            services.ConfigureControllers();
            services.ConfigureAutoMapper();
            services.ConfigureSwagger();
            services.ConfigureConfigSettings(Configuration);
            services.ConfigureDI();
            services.ConfigureVersioning();
        }
         
        public void Configure(IApplicationBuilder app, SwanSongContext swanSongcontext, IWebHostEnvironment env)
        {      
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SwanSong.Api v1"));
            
            app.UseRouting();
             
            app.UseCors(x => x
                .SetIsOriginAllowed(origin => true)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());

            app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseMiddleware<JwtMiddleware>();
            app.UseEndpoints(x => x.MapControllers());
        }
    }
}
