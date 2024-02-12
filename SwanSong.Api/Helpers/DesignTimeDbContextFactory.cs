using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using SwanSong.Data;
using SwanSong.Helper;

namespace SwanSong.Api.Helpers;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SwanSongContext>
{
    public SwanSongContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json")
            .Build();

        var builder = new DbContextOptionsBuilder<SwanSongContext>();

        builder.UseSqlServer(configuration.GetConnectionString(Constants.DatabaseConnectionString));

        return new SwanSongContext(builder.Options);
    }
}
