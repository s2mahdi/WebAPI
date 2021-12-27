using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class modifiedentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "Tickets",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceDate",
                table: "SamplingExperts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "SamplingExperts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "SamplingExperts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceDate",
                table: "CourseRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CourseTitle",
                table: "CourseRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExperts_StatusId",
                table: "SamplingExperts",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingExperts_Statuses_StatusId",
                table: "SamplingExperts",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SamplingExperts_Statuses_StatusId",
                table: "SamplingExperts");

            migrationBuilder.DropIndex(
                name: "IX_SamplingExperts_StatusId",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "InvoiceDate",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseTitle",
                table: "CourseRequests");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InvoiceDate",
                table: "CourseRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
