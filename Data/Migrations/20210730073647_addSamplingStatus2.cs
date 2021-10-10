using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addSamplingStatus2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SamplingExpertStatusHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SamplingExpertStatusHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SamplingExpertStatusHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "SamplingExpertStatusHistories",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SamplingExpertStatusHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SamplingExpertStatusHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SamplingExpertStatusHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SamplingExpertStatusHistories");
        }
    }
}
