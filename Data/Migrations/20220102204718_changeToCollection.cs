using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changeToCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequests_CourseRequestStatuses_CourseRequestStatusId",
                table: "CourseRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequests_Courses_CourseId",
                table: "CourseRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequestStatusHistories_CourseRequests_CourseRequestId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequestStatusHistories_CourseRequestStatuses_CourseRequestStatusId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Attachments_AttachmentId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Statuses_StatusId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SamplingExperts_Statuses_StatusId",
                table: "SamplingExperts");

            migrationBuilder.DropForeignKey(
                name: "FK_SamplingExpertStatusHistories_SamplingExperts_SamplingExpertId",
                table: "SamplingExpertStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_SamplingOperations_SampleTypes_SampleTypeId",
                table: "SamplingOperations");

            migrationBuilder.DropForeignKey(
                name: "FK_SamplingOperations_Statuses_StatusId",
                table: "SamplingOperations");

            migrationBuilder.DropIndex(
                name: "IX_SamplingOperations_SampleTypeId",
                table: "SamplingOperations");

            migrationBuilder.DropIndex(
                name: "IX_SamplingOperations_StatusId",
                table: "SamplingOperations");

            migrationBuilder.DropIndex(
                name: "IX_SamplingExpertStatusHistories_SamplingExpertId",
                table: "SamplingExpertStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_SamplingExperts_StatusId",
                table: "SamplingExperts");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_AttachmentId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequestStatusHistories_CourseRequestId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequestStatusHistories_CourseRequestStatusId",
                table: "CourseRequestStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequests_CourseId",
                table: "CourseRequests");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequests_CourseRequestStatusId",
                table: "CourseRequests");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SamplingExpertId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SamplingOperationId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SamplingExpertStatusHistoryId",
                table: "SamplingExperts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SamplingOperationId",
                table: "SampleTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseRequestId",
                table: "CourseRequestStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseRequestStatusHistoryId",
                table: "CourseRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Attachments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseCourseRequests",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CourseRequestsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCourseRequests", x => new { x.CourseId, x.CourseRequestsId });
                    table.ForeignKey(
                        name: "FK_CourseCourseRequests_CourseRequests_CourseRequestsId",
                        column: x => x.CourseRequestsId,
                        principalTable: "CourseRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseCourseRequests_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_InvoiceId",
                table: "Statuses",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_SamplingExpertId",
                table: "Statuses",
                column: "SamplingExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_SamplingOperationId",
                table: "Statuses",
                column: "SamplingOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExperts_SamplingExpertStatusHistoryId",
                table: "SamplingExperts",
                column: "SamplingExpertStatusHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleTypes_SamplingOperationId",
                table: "SampleTypes",
                column: "SamplingOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequestStatuses_CourseRequestId",
                table: "CourseRequestStatuses",
                column: "CourseRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequestStatuses_CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses",
                column: "CourseRequestStatusHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_CourseRequestStatusHistoryId",
                table: "CourseRequests",
                column: "CourseRequestStatusHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_InvoiceId",
                table: "Attachments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCourseRequests_CourseRequestsId",
                table: "CourseCourseRequests",
                column: "CourseRequestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_Invoices_InvoiceId",
                table: "Attachments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequests_CourseRequestStatusHistories_CourseRequestStatusHistoryId",
                table: "CourseRequests",
                column: "CourseRequestStatusHistoryId",
                principalTable: "CourseRequestStatusHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequestStatuses_CourseRequests_CourseRequestId",
                table: "CourseRequestStatuses",
                column: "CourseRequestId",
                principalTable: "CourseRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequestStatuses_CourseRequestStatusHistories_CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses",
                column: "CourseRequestStatusHistoryId",
                principalTable: "CourseRequestStatusHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleTypes_SamplingOperations_SamplingOperationId",
                table: "SampleTypes",
                column: "SamplingOperationId",
                principalTable: "SamplingOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingExperts_SamplingExpertStatusHistories_SamplingExpertStatusHistoryId",
                table: "SamplingExperts",
                column: "SamplingExpertStatusHistoryId",
                principalTable: "SamplingExpertStatusHistories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Invoices_InvoiceId",
                table: "Statuses",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_SamplingExperts_SamplingExpertId",
                table: "Statuses",
                column: "SamplingExpertId",
                principalTable: "SamplingExperts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_SamplingOperations_SamplingOperationId",
                table: "Statuses",
                column: "SamplingOperationId",
                principalTable: "SamplingOperations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_Invoices_InvoiceId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequests_CourseRequestStatusHistories_CourseRequestStatusHistoryId",
                table: "CourseRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequestStatuses_CourseRequests_CourseRequestId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseRequestStatuses_CourseRequestStatusHistories_CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleTypes_SamplingOperations_SamplingOperationId",
                table: "SampleTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_SamplingExperts_SamplingExpertStatusHistories_SamplingExpertStatusHistoryId",
                table: "SamplingExperts");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Invoices_InvoiceId",
                table: "Statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_SamplingExperts_SamplingExpertId",
                table: "Statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_SamplingOperations_SamplingOperationId",
                table: "Statuses");

            migrationBuilder.DropTable(
                name: "CourseCourseRequests");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_InvoiceId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_SamplingExpertId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_SamplingOperationId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_SamplingExperts_SamplingExpertStatusHistoryId",
                table: "SamplingExperts");

            migrationBuilder.DropIndex(
                name: "IX_SampleTypes_SamplingOperationId",
                table: "SampleTypes");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequestStatuses_CourseRequestId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequestStatuses_CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropIndex(
                name: "IX_CourseRequests_CourseRequestStatusHistoryId",
                table: "CourseRequests");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_InvoiceId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "SamplingExpertId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "SamplingOperationId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "SamplingExpertStatusHistoryId",
                table: "SamplingExperts");

            migrationBuilder.DropColumn(
                name: "SamplingOperationId",
                table: "SampleTypes");

            migrationBuilder.DropColumn(
                name: "CourseRequestId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "CourseRequestStatusHistoryId",
                table: "CourseRequestStatuses");

            migrationBuilder.DropColumn(
                name: "CourseRequestStatusHistoryId",
                table: "CourseRequests");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Attachments");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingOperations_SampleTypeId",
                table: "SamplingOperations",
                column: "SampleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingOperations_StatusId",
                table: "SamplingOperations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExpertStatusHistories_SamplingExpertId",
                table: "SamplingExpertStatusHistories",
                column: "SamplingExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExperts_StatusId",
                table: "SamplingExperts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_AttachmentId",
                table: "Invoices",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequestStatusHistories_CourseRequestId",
                table: "CourseRequestStatusHistories",
                column: "CourseRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequestStatusHistories_CourseRequestStatusId",
                table: "CourseRequestStatusHistories",
                column: "CourseRequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_CourseId",
                table: "CourseRequests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_CourseRequestStatusId",
                table: "CourseRequests",
                column: "CourseRequestStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequests_CourseRequestStatuses_CourseRequestStatusId",
                table: "CourseRequests",
                column: "CourseRequestStatusId",
                principalTable: "CourseRequestStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequests_Courses_CourseId",
                table: "CourseRequests",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequestStatusHistories_CourseRequests_CourseRequestId",
                table: "CourseRequestStatusHistories",
                column: "CourseRequestId",
                principalTable: "CourseRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseRequestStatusHistories_CourseRequestStatuses_CourseRequestStatusId",
                table: "CourseRequestStatusHistories",
                column: "CourseRequestStatusId",
                principalTable: "CourseRequestStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Attachments_AttachmentId",
                table: "Invoices",
                column: "AttachmentId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Statuses_StatusId",
                table: "Invoices",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingExperts_Statuses_StatusId",
                table: "SamplingExperts",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingExpertStatusHistories_SamplingExperts_SamplingExpertId",
                table: "SamplingExpertStatusHistories",
                column: "SamplingExpertId",
                principalTable: "SamplingExperts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingOperations_SampleTypes_SampleTypeId",
                table: "SamplingOperations",
                column: "SampleTypeId",
                principalTable: "SampleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SamplingOperations_Statuses_StatusId",
                table: "SamplingOperations",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
