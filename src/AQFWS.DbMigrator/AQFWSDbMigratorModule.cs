using AQFWS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AQFWS.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AQFWSEntityFrameworkCoreDbMigrationsModule),
        typeof(AQFWSApplicationContractsModule)
        )]
    public class AQFWSDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
