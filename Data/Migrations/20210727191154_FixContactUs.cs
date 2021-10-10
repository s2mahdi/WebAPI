using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FixContactUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Contactuses");

            migrationBuilder.AddColumn<decimal>(
                name: "Location_Intute",
                table: "Contactuses",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Location_Latitut",
                table: "Contactuses",
                type: "decimal(18,2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location_Intute",
                table: "Contactuses");

            migrationBuilder.DropColumn(
                name: "Location_Latitut",
                table: "Contactuses");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Contactuses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
