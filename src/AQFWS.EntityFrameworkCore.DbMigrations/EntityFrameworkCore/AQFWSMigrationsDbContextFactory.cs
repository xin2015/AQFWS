using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AQFWS.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AQFWSMigrationsDbContextFactory : IDesignTimeDbContextFactory<AQFWSMigrationsDbContext>
    {
        public AQFWSMigrationsDbContext CreateDbContext(string[] args)
        {
            AQFWSEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AQFWSMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AQFWSMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AQFWS.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
