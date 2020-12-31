using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AQFWS.Migrations
{
    public partial class Add_Area_Station_AirQualityRecord_Entites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyAppLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyAppLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyAppLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyAppLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyAppStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyAppStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyAppStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyAppStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyPubLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyPubLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyPubLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyPubLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyPubStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyPubStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlyPubStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlyPubStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlySrcLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlySrcLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlySrcLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlySrcLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlySrcStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlySrcStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexMonthlySrcStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexMonthlySrcStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyAppLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyAppLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyAppStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyAppStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyPubLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyPubLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyPubStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlyPubStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlySrcLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlySrcLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlySrcStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexQuarterlySrcStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyAppLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyAppLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyAppLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyAppLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyAppStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyAppStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyAppStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyAppStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyPubLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyPubLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyPubLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyPubLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyPubStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyPubStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlyPubStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlyPubStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlySrcLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlySrcLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlySrcLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlySrcLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlySrcStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlySrcStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityCompositeIndexYearlySrcStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQCI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValidCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonExceedenceCount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityCompositeIndexYearlySrcStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyAppLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyAppLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyAppLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyAppLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyAppStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyAppStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyAppStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyAppStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyPubLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyPubLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyPubLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyPubLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyPubStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyPubStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailyPubStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailyPubStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailySrcLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailySrcLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailySrcLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailySrcLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailySrcStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailySrcStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexDailySrcStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexDailySrcStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyAppLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyAppLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyAppLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyAppLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyAppStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyAppStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyAppStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyAppStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyPubLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyPubLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyPubLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyPubLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyPubStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyPubStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlyPubStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlyPubStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlySrcLiveAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlySrcLiveAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlySrcLiveRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlySrcLiveRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlySrcStdAreaRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlySrcStdAreaRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAirQualityIndexHourlySrcStdRecords",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    SO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NO2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    O3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM10 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PM25 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PrimaryPollutant = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AQI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AQIType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAirQualityIndexHourlySrcStdRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppAreas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppStations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    IsCompared = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStations_AppAreas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "AppAreas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyAppLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyAppLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyAppLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyAppLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyAppStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyAppStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyAppStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyAppStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyPubLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyPubLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyPubLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyPubLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyPubStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyPubStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlyPubStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlyPubStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlySrcLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlySrcLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlySrcLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlySrcLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlySrcStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlySrcStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexMonthlySrcStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexMonthlySrcStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyAppLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyAppLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyAppLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyAppLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyAppStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyAppStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyAppStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyAppStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyPubLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyPubLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyPubLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyPubLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyPubStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyPubStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlyPubStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlyPubStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlySrcLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlySrcLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlySrcLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlySrcLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlySrcStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlySrcStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexQuarterlySrcStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexQuarterlySrcStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyAppLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyAppLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyAppLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyAppLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyAppStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyAppStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyAppStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyAppStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyPubLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyPubLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyPubLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyPubLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyPubStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyPubStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlyPubStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlyPubStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlySrcLiveAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlySrcLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlySrcLiveRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlySrcLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlySrcStdAreaRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlySrcStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityCompositeIndexYearlySrcStdRecords_Time_Code",
                table: "AppAirQualityCompositeIndexYearlySrcStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyAppLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailyAppLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyAppLiveRecords_Time_Code",
                table: "AppAirQualityIndexDailyAppLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyAppStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailyAppStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyAppStdRecords_Time_Code",
                table: "AppAirQualityIndexDailyAppStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyPubLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailyPubLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyPubLiveRecords_Time_Code",
                table: "AppAirQualityIndexDailyPubLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyPubStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailyPubStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailyPubStdRecords_Time_Code",
                table: "AppAirQualityIndexDailyPubStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailySrcLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailySrcLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailySrcLiveRecords_Time_Code",
                table: "AppAirQualityIndexDailySrcLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailySrcStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexDailySrcStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexDailySrcStdRecords_Time_Code",
                table: "AppAirQualityIndexDailySrcStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyAppLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlyAppLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyAppLiveRecords_Time_Code",
                table: "AppAirQualityIndexHourlyAppLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyAppStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlyAppStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyAppStdRecords_Time_Code",
                table: "AppAirQualityIndexHourlyAppStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyPubLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlyPubLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyPubLiveRecords_Time_Code",
                table: "AppAirQualityIndexHourlyPubLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyPubStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlyPubStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlyPubStdRecords_Time_Code",
                table: "AppAirQualityIndexHourlyPubStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlySrcLiveAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlySrcLiveAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlySrcLiveRecords_Time_Code",
                table: "AppAirQualityIndexHourlySrcLiveRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlySrcStdAreaRecords_Time_Code",
                table: "AppAirQualityIndexHourlySrcStdAreaRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppAirQualityIndexHourlySrcStdRecords_Time_Code",
                table: "AppAirQualityIndexHourlySrcStdRecords",
                columns: new[] { "Time", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppStations_AreaId",
                table: "AppStations",
                column: "AreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyAppLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyAppLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyAppStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyAppStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyPubLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyPubLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyPubStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlyPubStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlySrcLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlySrcLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlySrcStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexMonthlySrcStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyAppStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlyPubStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexQuarterlySrcStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyAppLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyAppLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyAppStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyAppStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyPubLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyPubLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyPubStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlyPubStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlySrcLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlySrcLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlySrcStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityCompositeIndexYearlySrcStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyAppLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyAppLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyAppStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyAppStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyPubLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyPubLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyPubStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailyPubStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailySrcLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailySrcLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailySrcStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexDailySrcStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyAppLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyAppLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyAppStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyAppStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyPubLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyPubLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyPubStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlyPubStdRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlySrcLiveAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlySrcLiveRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlySrcStdAreaRecords");

            migrationBuilder.DropTable(
                name: "AppAirQualityIndexHourlySrcStdRecords");

            migrationBuilder.DropTable(
                name: "AppStations");

            migrationBuilder.DropTable(
                name: "AppAreas");
        }
    }
}
