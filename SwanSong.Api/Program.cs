using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using SwanSong.Api.Helpers.Extensions;
using SwanSong.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);
 
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    config.AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);
    config.AddEnvironmentVariables();
}); 

builder.Services.ConfigureMvc();
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureCors();
builder.Services.ConfigureControllers();
builder.Services.ConfigureAutoMapper();
builder.Services.ConfigureSwagger(); 
builder.Services.ConfigureDI();
builder.Services.ConfigureVersioning();

var app = builder.Build();
 
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
 
app.Run();