using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AQFWS.EntityFrameworkCore
{
    [DependsOn(
        typeof(AQFWSEntityFrameworkCoreModule)
        )]
    public class AQFWSEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AQFWSMigrationsDbContext>();
        }
    }
}
