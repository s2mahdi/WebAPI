using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class add_SamplingOperations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SampleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SamplingExperts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamplingExperts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SamplingOperations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SampleCount = table.Column<int>(type: "int", nullable: false),
                    SiteAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tell = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LetterNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LetterPath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceId = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    InvoiceDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoicePrice = table.Column<int>(type: "int", nullable: false),
                    InvoicePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleTypeId = table.Column<int>(type: "int", nullable: false),
                    DeviceTypeId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SamplingOperations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SamplingOperations_DeviceTypes_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "DeviceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SamplingOperations_SampleTypes_SampleTypeId",
                        column: x => x.SampleTypeId,
                        principalTable: "SampleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SamplingOperations_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SamplingOperations_DeviceTypeId",
                table: "SamplingOperations",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingOperations_SampleTypeId",
                table: "SamplingOperations",
                column: "SampleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SamplingOperations_StatusId",
                table: "SamplingOperations",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SamplingExperts");

            migrationBuilder.DropTable(
                name: "SamplingOperations");

            migrationBuilder.DropTable(
                name: "DeviceTypes");

            migrationBuilder.DropTable(
                name: "SampleTypes");
        }
    }
}
