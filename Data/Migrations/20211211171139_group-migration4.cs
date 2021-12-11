using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class groupmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }
    }
}
