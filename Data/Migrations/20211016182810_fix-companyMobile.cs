using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class fixcompanyMobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "MobileActivations",
                newName: "CreateDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateActiveByUser",
                table: "CompanyUserMobiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateActiveByUser",
                table: "CompanyUserMobiles");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "MobileActivations",
                newName: "CreateTime");
        }
    }
}
