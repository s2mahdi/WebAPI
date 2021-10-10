using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class audit007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Tickets",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Tickets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Statuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Statuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SmsLoginEvents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SmsLoginEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SmsLoginEvents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "SmsLoginEvents",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Sections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Sections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SamplingOperations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SamplingOperations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SamplingOperations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "SamplingOperations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SamplingExperts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SamplingExperts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SamplingExperts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "SamplingExperts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "SampleTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SampleTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "SampleTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "SampleTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Parts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Parts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Parts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Parts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "News",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "News",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "News",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "News",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeviceTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "DeviceTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "DeviceTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "DeviceTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeviceProducers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "DeviceProducers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "DeviceProducers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "DeviceProducers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeviceNames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "DeviceNames",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "DeviceNames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "DeviceNames",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "DeviceModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "DeviceModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "DeviceModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "DeviceModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Courses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "CourseRequestStatusHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CourseRequestStatusHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "CourseRequestStatusHistories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "CourseRequestStatusHistories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "CourseRequestStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CourseRequestStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "CourseRequestStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "CourseRequestStatuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "CourseRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "CourseRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "CourseRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "CourseRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Contactuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Contactuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Contactuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Contactuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Aboutuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Aboutuses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedByUserId",
                table: "Aboutuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDateTime",
                table: "Aboutuses",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SmsLoginEvents");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SmsLoginEvents");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SmsLoginEvents");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SmsLoginEvents");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SamplingOperations");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SamplingOperations");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SamplingOperations");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SamplingOperations");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "SampleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SampleTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "SampleTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "SampleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeviceTypes");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "DeviceTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "DeviceTypes");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "DeviceTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeviceProducers");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "DeviceProducers");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "DeviceProducers");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "DeviceProducers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeviceNames");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "DeviceNames");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "DeviceNames");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "DeviceNames");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "DeviceModels");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "DeviceModels");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "DeviceModels");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "DeviceModels");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Contactuses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Contactuses");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Contactuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Contactuses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Aboutuses");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Aboutuses");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Aboutuses");

            migrationBuilder.DropColumn(
                name: "ModifiedDateTime",
                table: "Aboutuses");
        }
    }
}
