using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AQFWS.Data;
using Volo.Abp.DependencyInjection;

namespace AQFWS.EntityFrameworkCore
{
    public class EntityFrameworkCoreAQFWSDbSchemaMigrator
        : IAQFWSDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAQFWSDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AQFWSMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AQFWSMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}