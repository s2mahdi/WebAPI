using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class audit12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Assets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Assets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Assets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AssetParts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "AssetParts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "AssetParts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AssetParts",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AssetParts");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "AssetParts");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "AssetParts");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "AssetParts");
        }
    }
}
