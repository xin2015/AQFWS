using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AQFWS.EntityFrameworkCore
{
    public static class AQFWSDbContextModelCreatingExtensions
    {
        public static void ConfigureAQFWS(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AQFWSConsts.DbTablePrefix + "YourEntities", AQFWSConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}