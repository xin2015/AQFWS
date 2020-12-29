using Volo.Abp.Modularity;

namespace AQFWS
{
    [DependsOn(
        typeof(AQFWSApplicationModule),
        typeof(AQFWSDomainTestModule)
        )]
    public class AQFWSApplicationTestModule : AbpModule
    {

    }
}