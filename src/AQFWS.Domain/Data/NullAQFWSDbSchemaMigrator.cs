using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AQFWS.Data
{
    /* This is used if database provider does't define
     * IAQFWSDbSchemaMigrator implementation.
     */
    public class NullAQFWSDbSchemaMigrator : IAQFWSDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}