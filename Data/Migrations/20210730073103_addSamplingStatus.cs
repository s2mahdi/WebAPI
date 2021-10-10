using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addSamplingStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SamplingExpertStatusHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    SamplingExpertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamplingExpertStatusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SamplingExpertStatusHistories_SamplingExperts_SamplingExpertId",
                        column: x => x.SamplingExpertId,
                        principalTable: "SamplingExperts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SamplingExpertStatusHistories_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExpertStatusHistories_SamplingExpertId",
                table: "SamplingExpertStatusHistories",
                column: "SamplingExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingExpertStatusHistories_StatusId",
                table: "SamplingExpertStatusHistories",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamplingExpertStatusHistories");
        }
    }
}
