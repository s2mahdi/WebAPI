using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AssetsAuditable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Posts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "AspNetRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "AspNetRoles");
        }
    }
}
