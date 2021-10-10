using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addTicketAndAssets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceKind = table.Column<int>(type: "int", nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeviceModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DeviceProducer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProduceYear = table.Column<int>(type: "int", nullable: false),
                    AvgWorkPerDay = table.Column<float>(type: "real", nullable: false),
                    WorkPerDayKind = table.Column<int>(type: "int", nullable: false),
                    WorkPerWeek = table.Column<int>(type: "int", nullable: false),
                    OilVolume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OilVolumeKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticaly = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransOil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransOilKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransOilSharing = table.Column<bool>(type: "bit", nullable: false),
                    TapchangerOil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TapchangerOilKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoltageFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoltageFirstKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoltageSecend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoltageSecendKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransLoad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransLoadKind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceProducers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Producer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceProducers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PartKind = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileAttach = table.Column<int>(type: "int", nullable: false),
                    AnswerBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnswerUser = table.Column<int>(type: "int", nullable: false),
                    GroupTitle = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartId = table.Column<int>(type: "int", nullable: false),
                    AssetId = table.Column<int>(type: "int", nullable: false),
                    PartNewName = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    PartDesc = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    VolumeKind = table.Column<int>(type: "int", nullable: false),
                    OilChange = table.Column<int>(type: "int", nullable: false),
                    OilChangeType = table.Column<int>(type: "int", nullable: false),
                    OilSampling = table.Column<int>(type: "int", nullable: false),
                    OilSamplingType = table.Column<int>(type: "int", nullable: false),
                    DescPart = table.Column<int>(type: "int", nullable: false),
                    OilChangeDate = table.Column<int>(type: "int", nullable: false),
                    OilPhysicalFilteringDate = table.Column<int>(type: "int", nullable: false),
                    OilChemicalFilteringDate = table.Column<int>(type: "int", nullable: false),
                    OverhaulDate = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    DescOilChange = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetParts_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetParts_AssetId",
                table: "AssetParts",
                column: "AssetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetParts");

            migrationBuilder.DropTable(
                name: "DeviceModels");

            migrationBuilder.DropTable(
                name: "DeviceNames");

            migrationBuilder.DropTable(
                name: "DeviceProducers");

            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
