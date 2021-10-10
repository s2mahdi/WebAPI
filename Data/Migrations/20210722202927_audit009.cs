using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class audit009 : Migration
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
