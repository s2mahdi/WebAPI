using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FixContactUs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Location_Latitut",
                table: "Contactuses",
                type: "decimal(18,9)",
                precision: 18,
                scale: 9,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Location_Intute",
                table: "Contactuses",
                type: "decimal(18,9)",
                precision: 18,
                scale: 9,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Location_Latitut",
                table: "Contactuses",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,9)",
                oldPrecision: 18,
                oldScale: 9,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Location_Intute",
                table: "Contactuses",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,9)",
                oldPrecision: 18,
                oldScale: 9,
                oldNullable: true);
        }
    }
}
