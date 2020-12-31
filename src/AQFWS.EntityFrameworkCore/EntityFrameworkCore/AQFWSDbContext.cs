using Microsoft.EntityFrameworkCore;
using AQFWS.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
using AQFWS.Areas;
using AQFWS.Stations;
using AQFWS.AirQualityRecords;
using AQFWS.AirQualityAreaRecords;

namespace AQFWS.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See AQFWSMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class AQFWSDbContext : AbpDbContext<AQFWSDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside AQFWSDbContextModelCreatingExtensions.ConfigureAQFWS
         */

        public DbSet<Area> Areas { get; set; }

        public DbSet<Station> Stations { get; set; }

        public DbSet<AirQualityIndexHourlySrcLiveRecord> AirQualityIndexHourlySrcLiveRecords { get; set; }

        public DbSet<AirQualityIndexHourlySrcStdRecord> AirQualityIndexHourlySrcStdRecords { get; set; }

        public DbSet<AirQualityIndexHourlyPubLiveRecord> AirQualityIndexHourlyPubLiveRecords { get; set; }

        public DbSet<AirQualityIndexHourlyPubStdRecord> AirQualityIndexHourlyPubStdRecords { get; set; }

        public DbSet<AirQualityIndexHourlyAppLiveRecord> AirQualityIndexHourlyAppLiveRecords { get; set; }

        public DbSet<AirQualityIndexHourlyAppStdRecord> AirQualityIndexHourlyAppStdRecords { get; set; }

        public DbSet<AirQualityIndexDailySrcLiveRecord> AirQualityIndexDailySrcLiveRecords { get; set; }

        public DbSet<AirQualityIndexDailySrcStdRecord> AirQualityIndexDailySrcStdRecords { get; set; }

        public DbSet<AirQualityIndexDailyPubLiveRecord> AirQualityIndexDailyPubLiveRecords { get; set; }

        public DbSet<AirQualityIndexDailyPubStdRecord> AirQualityIndexDailyPubStdRecords { get; set; }

        public DbSet<AirQualityIndexDailyAppLiveRecord> AirQualityIndexDailyAppLiveRecords { get; set; }

        public DbSet<AirQualityIndexDailyAppStdRecord> AirQualityIndexDailyAppStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlySrcLiveRecord> AirQualityCompositeIndexMonthlySrcLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlySrcStdRecord> AirQualityCompositeIndexMonthlySrcStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyPubLiveRecord> AirQualityCompositeIndexMonthlyPubLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyPubStdRecord> AirQualityCompositeIndexMonthlyPubStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyAppLiveRecord> AirQualityCompositeIndexMonthlyAppLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyAppStdRecord> AirQualityCompositeIndexMonthlyAppStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlySrcLiveRecord> AirQualityCompositeIndexQuarterlySrcLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlySrcStdRecord> AirQualityCompositeIndexQuarterlySrcStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyPubLiveRecord> AirQualityCompositeIndexQuarterlyPubLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyPubStdRecord> AirQualityCompositeIndexQuarterlyPubStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyAppLiveRecord> AirQualityCompositeIndexQuarterlyAppLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyAppStdRecord> AirQualityCompositeIndexQuarterlyAppStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlySrcLiveRecord> AirQualityCompositeIndexYearlySrcLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlySrcStdRecord> AirQualityCompositeIndexYearlySrcStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyPubLiveRecord> AirQualityCompositeIndexYearlyPubLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyPubStdRecord> AirQualityCompositeIndexYearlyPubStdRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyAppLiveRecord> AirQualityCompositeIndexYearlyAppLiveRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyAppStdRecord> AirQualityCompositeIndexYearlyAppStdRecords { get; set; }

        public DbSet<AirQualityIndexHourlySrcLiveAreaRecord> AirQualityIndexHourlySrcLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexHourlySrcStdAreaRecord> AirQualityIndexHourlySrcStdAreaRecords { get; set; }

        public DbSet<AirQualityIndexHourlyPubLiveAreaRecord> AirQualityIndexHourlyPubLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexHourlyPubStdAreaRecord> AirQualityIndexHourlyPubStdAreaRecords { get; set; }

        public DbSet<AirQualityIndexHourlyAppLiveAreaRecord> AirQualityIndexHourlyAppLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexHourlyAppStdAreaRecord> AirQualityIndexHourlyAppStdAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailySrcLiveAreaRecord> AirQualityIndexDailySrcLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailySrcStdAreaRecord> AirQualityIndexDailySrcStdAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailyPubLiveAreaRecord> AirQualityIndexDailyPubLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailyPubStdAreaRecord> AirQualityIndexDailyPubStdAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailyAppLiveAreaRecord> AirQualityIndexDailyAppLiveAreaRecords { get; set; }

        public DbSet<AirQualityIndexDailyAppStdAreaRecord> AirQualityIndexDailyAppStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlySrcLiveAreaRecord> AirQualityCompositeIndexMonthlySrcLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlySrcStdAreaRecord> AirQualityCompositeIndexMonthlySrcStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyPubLiveAreaRecord> AirQualityCompositeIndexMonthlyPubLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyPubStdAreaRecord> AirQualityCompositeIndexMonthlyPubStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyAppLiveAreaRecord> AirQualityCompositeIndexMonthlyAppLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexMonthlyAppStdAreaRecord> AirQualityCompositeIndexMonthlyAppStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlySrcLiveAreaRecord> AirQualityCompositeIndexQuarterlySrcLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlySrcStdAreaRecord> AirQualityCompositeIndexQuarterlySrcStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyPubLiveAreaRecord> AirQualityCompositeIndexQuarterlyPubLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyPubStdAreaRecord> AirQualityCompositeIndexQuarterlyPubStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyAppLiveAreaRecord> AirQualityCompositeIndexQuarterlyAppLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexQuarterlyAppStdAreaRecord> AirQualityCompositeIndexQuarterlyAppStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlySrcLiveAreaRecord> AirQualityCompositeIndexYearlySrcLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlySrcStdAreaRecord> AirQualityCompositeIndexYearlySrcStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyPubLiveAreaRecord> AirQualityCompositeIndexYearlyPubLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyPubStdAreaRecord> AirQualityCompositeIndexYearlyPubStdAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyAppLiveAreaRecord> AirQualityCompositeIndexYearlyAppLiveAreaRecords { get; set; }

        public DbSet<AirQualityCompositeIndexYearlyAppStdAreaRecord> AirQualityCompositeIndexYearlyAppStdAreaRecords { get; set; }


        public AQFWSDbContext(DbContextOptions<AQFWSDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the AQFWSEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureAQFWS method */

            builder.ConfigureAQFWS();
        }
    }
}
