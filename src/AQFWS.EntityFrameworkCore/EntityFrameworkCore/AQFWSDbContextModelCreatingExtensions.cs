using AQFWS.AirQualityAreaRecords;
using AQFWS.AirQualityRecords;
using AQFWS.Areas;
using AQFWS.Stations;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

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

            builder.Entity<Station>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "Stations", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);

                b.HasOne<Area>().WithMany().HasForeignKey(x => x.AreaId).IsRequired();
            });

            builder.Entity<Area>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "Areas", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });

            #region AirQualityRecord
            #region AirQualityIndexRecord
            #region AirQualityIndexHourlyRecord
            builder.Entity<AirQualityIndexHourlySrcLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlySrcLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlySrcStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlySrcStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyPubLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyPubLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyPubStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyPubStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyAppLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyAppLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyAppStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyAppStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityIndexDailyRecord
            builder.Entity<AirQualityIndexDailySrcLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailySrcLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailySrcStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailySrcStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyPubLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyPubLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyPubStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyPubStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyAppLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyAppLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyAppStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyAppStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion
            #endregion

            #region AirQualityCompositeIndexRecord
            #region AirQualityCompositeIndexMonthlyRecord
            builder.Entity<AirQualityCompositeIndexMonthlySrcLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlySrcLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlySrcStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlySrcStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyPubLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyPubLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyPubStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyPubStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyAppLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyAppLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyAppStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyAppStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityCompositeIndexQuarterlyRecord
            builder.Entity<AirQualityCompositeIndexQuarterlySrcLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlySrcLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlySrcStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlySrcStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyPubLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyPubLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyPubStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyPubStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyAppLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyAppLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyAppStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyAppStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityCompositeIndexYearlyRecord
            builder.Entity<AirQualityCompositeIndexYearlySrcLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlySrcLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlySrcStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlySrcStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyPubLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyPubLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyPubStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyPubStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyAppLiveRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyAppLiveRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyAppStdRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyAppStdRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion
            #endregion
            #endregion

            #region AirQualityAreaRecord
            #region AirQualityIndexAreaRecord
            #region AirQualityIndexHourlyAreaRecord
            builder.Entity<AirQualityIndexHourlySrcLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlySrcLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlySrcStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlySrcStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyPubLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyPubLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyPubStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyPubStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyAppLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyAppLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexHourlyAppStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexHourlyAppStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityIndexDailyAreaRecord
            builder.Entity<AirQualityIndexDailySrcLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailySrcLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailySrcStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailySrcStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyPubLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyPubLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyPubStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyPubStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyAppLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyAppLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityIndexDailyAppStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityIndexDailyAppStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);
                b.Property(x => x.AQIType).IsRequired().HasMaxLength(64);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion
            #endregion

            #region AirQualityCompositeIndexAreaRecord
            #region AirQualityCompositeIndexMonthlyAreaRecord
            builder.Entity<AirQualityCompositeIndexMonthlySrcLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlySrcLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlySrcStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlySrcStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyPubLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyPubLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyPubStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyPubStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyAppLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyAppLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexMonthlyAppStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexMonthlyAppStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityCompositeIndexQuarterlyAreaRecord
            builder.Entity<AirQualityCompositeIndexQuarterlySrcLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlySrcLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlySrcStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlySrcStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyPubLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyPubLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyPubStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyPubStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyAppLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyAppLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexQuarterlyAppStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexQuarterlyAppStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion

            #region AirQualityCompositeIndexYearlyAreaRecord
            builder.Entity<AirQualityCompositeIndexYearlySrcLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlySrcLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlySrcStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlySrcStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyPubLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyPubLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyPubStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyPubStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyAppLiveAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyAppLiveAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });

            builder.Entity<AirQualityCompositeIndexYearlyAppStdAreaRecord>(b =>
            {
                b.ToTable(AQFWSConsts.DbTablePrefix + "AirQualityCompositeIndexYearlyAppStdAreaRecords", AQFWSConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Code).IsRequired().HasMaxLength(64);
                b.Property(x => x.PrimaryPollutant).IsRequired().HasMaxLength(128);

                b.HasIndex(x => new { x.Time, x.Code }).IsUnique();
            });
            #endregion
            #endregion
            #endregion
        }
    }
}