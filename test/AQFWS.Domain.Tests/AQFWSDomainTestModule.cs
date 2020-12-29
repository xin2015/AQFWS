using AQFWS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AQFWS
{
    [DependsOn(
        typeof(AQFWSEntityFrameworkCoreTestModule)
        )]
    public class AQFWSDomainTestModule : AbpModule
    {

    }
}