using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class invoicechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "invoicePrice",
                table: "Invoices",
                newName: "InvoicePrice");

            migrationBuilder.RenameColumn(
                name: "invoiceDate",
                table: "Invoices",
                newName: "InvoiceDate");

            migrationBuilder.AlterColumn<decimal>(
                name: "InvoicePrice",
                table: "Invoices",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceDate",
                table: "Invoices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestLetterDate",
                table: "Invoices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RequestLetterNo",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusName",
                table: "Invoices",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "VAT",
                table: "Invoices",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Statuses_StatusId",
                table: "Invoices",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Statuses_StatusId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_StatusId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RequestLetterDate",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "RequestLetterNo",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "VAT",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "InvoicePrice",
                table: "Invoices",
                newName: "invoicePrice");

            migrationBuilder.RenameColumn(
                name: "InvoiceDate",
                table: "Invoices",
                newName: "invoiceDate");

            migrationBuilder.AlterColumn<int>(
                name: "invoicePrice",
                table: "Invoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "invoiceDate",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
