using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class entitiesmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Statuses_StatusId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "CourseRequestId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentID",
                table: "Statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentReceiptId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusColorCode",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Statuses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentReceiptId",
                table: "Attachments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_CourseRequestId",
                table: "Statuses",
                column: "CourseRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_PaymentReceiptId",
                table: "Statuses",
                column: "PaymentReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_TicketId",
                table: "Statuses",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_PaymentReceiptId",
                table: "Attachments",
                column: "PaymentReceiptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_PaymentReceipts_PaymentReceiptId",
                table: "Attachments",
                column: "PaymentReceiptId",
                principalTable: "PaymentReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_CourseRequests_CourseRequestId",
                table: "Statuses",
                column: "CourseRequestId",
                principalTable: "CourseRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_PaymentReceipts_PaymentReceiptId",
                table: "Statuses",
                column: "PaymentReceiptId",
                principalTable: "PaymentReceipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Statuses_Tickets_TicketId",
                table: "Statuses",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_PaymentReceipts_PaymentReceiptId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_CourseRequests_CourseRequestId",
                table: "Statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_PaymentReceipts_PaymentReceiptId",
                table: "Statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_Statuses_Tickets_TicketId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_CourseRequestId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_PaymentReceiptId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Statuses_TicketId",
                table: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_PaymentReceiptId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "CourseRequestId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "ParentID",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "PaymentReceiptId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "StatusColorCode",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "PaymentReceiptId",
                table: "Attachments");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Statuses_StatusId",
                table: "Tickets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }
    }
}
