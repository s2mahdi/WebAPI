using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddCompanyMobileAndMobileActivation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyUserMobiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExpireDateAccess = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyUserMobiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileActivations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ActivationCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileActivations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyUserMobiles");

            migrationBuilder.DropTable(
                name: "MobileActivations");
        }
    }
}
