using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Realtair.LocalDebugger.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class LocalDebuggerDbContextFactory : IDesignTimeDbContextFactory<LocalDebuggerDbContext>
{
    public LocalDebuggerDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        LocalDebuggerEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<LocalDebuggerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new LocalDebuggerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Realtair.LocalDebugger.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
