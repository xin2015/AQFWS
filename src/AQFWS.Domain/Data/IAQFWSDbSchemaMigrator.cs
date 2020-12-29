using System.Threading.Tasks;

namespace AQFWS.Data
{
    public interface IAQFWSDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
