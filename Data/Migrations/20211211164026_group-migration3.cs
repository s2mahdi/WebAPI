using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class groupmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "GroupTitle",
                table: "Tickets");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "GroupTitle",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Groups_GroupId",
                table: "Tickets",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
