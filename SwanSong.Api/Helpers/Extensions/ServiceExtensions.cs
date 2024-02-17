using Asp.Versioning;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using SwanSong.Azure.Storage;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Business.Validator;
using SwanSong.Data;
using SwanSong.Data.Repository;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Data.UnitOfWork;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Service;
using SwanSong.Service.Interfaces;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json.Serialization;

namespace SwanSong.Api.Helpers.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder => builder.AllowAnyOrigin() 
                .AllowAnyMethod()
                .AllowAnyHeader());
        });
    }

    public static void ConfigureSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "SwanSong API",
                Description = "An ASP.NET Core Web API for accessing/managing SwanSong SqlServer DB",
            });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            option.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        }); 
    }

    public static void ConfigureDbContext(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<SwanSongContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString(Constants.DatabaseConnectionString),
            options => options.EnableRetryOnFailure()
            .MigrationsAssembly(typeof(SwanSongContext).Assembly.FullName))); 
    }

    public static void ConfigureDI(this IServiceCollection services)
    {
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<IAlbumRepository, AlbumRepository>();
        services.AddScoped<IAlbumService, AlbumService>();
        services.AddScoped<IAlbumSongRepository, AlbumSongRepository>();
        services.AddScoped<IAlbumSongService, AlbumSongService>();
        services.AddScoped<IAuthenticateService, AuthenticateService>();
        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<IMemberService, MemberService>();
        services.AddScoped<IArtistRepository, ArtistRepository>();
        services.AddScoped<IArtistService, ArtistService>();
        services.AddScoped<IBirthPlaceRepository, BirthPlaceRepository>();
        services.AddScoped<IBirthPlaceService, BirthPlaceService>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<ICountryService, CountryService>(); 
        services.AddScoped<IStudioRepository, StudioRepository>();
        services.AddScoped<IStudioService, StudioService>();
        services.AddScoped<IProfileService, ProfileService>();
        services.AddScoped<IProfilePasswordChangeService, ProfilePasswordChangeService>();
        services.AddScoped<IRecordLabelRepository, RecordLabelRepository>();
        services.AddScoped<IRecordLabelService, RecordLabelService>();
        services.AddScoped<IRegisterService, RegisterService>();
        services.AddScoped<IRegisterVerifyEmailService, RegisterVerifyEmailService>();
        services.AddScoped<IResetPasswordService, ResetPasswordService>();
        services.AddScoped<IRefreshTokenService, RefreshTokenService>();
        services.AddScoped<ISongRepository, SongRepository>();
        services.AddScoped<ISongService, SongService>();  
        services.AddScoped<IAzureStorageBlobHelper, AzureStorageBlobHelper>();
        services.AddTransient(typeof(IValidatorHelper<>), typeof(ValidatorHelper<>)); 
        services.AddValidatorsFromAssemblyContaining<AlbumValidator>(); 
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
        services.AddTransient<IUnitOfWork, UnitOfWork>(); 

        services.AddMemoryCache();
    }         

    public static void ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers()
           .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
           .AddJsonOptions(x => x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);
    }

    public static void ConfigureMvc(this IServiceCollection services)
    { 
        services.AddMvc(options =>
        {
            options.SuppressAsyncSuffixInActionNames = false;
        })
        .ConfigureApiBehaviorOptions(options =>
        {
             options.SuppressModelStateInvalidFilter = true;
        });
    }

    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfile)));
    }       

    public static void ConfigureVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.ReportApiVersions = true;
        });
    }
}