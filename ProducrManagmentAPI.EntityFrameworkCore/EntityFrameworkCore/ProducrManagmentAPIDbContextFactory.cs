using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProducrManagmentAPI.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProducrManagmentAPIDbContextFactory : IDesignTimeDbContextFactory<ProducrManagmentAPIDbContext>
{
    public ProducrManagmentAPIDbContext CreateDbContext(string[] args)
    {
        ProducrManagmentAPIEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProducrManagmentAPIDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProducrManagmentAPIDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProducrManagmentAPI.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
