using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class RepairDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RepairDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SparePartsId = table.Column<int>(type: "int", nullable: false),
                    SparePartId = table.Column<int>(type: "int", nullable: false),
                    SpareRecordsId = table.Column<int>(type: "int", nullable: false),
                    ServiveRecordsId = table.Column<int>(type: "int", nullable: false),
                    UsedSpareParts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsedSparePartsAmount = table.Column<int>(type: "int", nullable: false),
                    UsedSparePartsCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairDetail_ServiceRecords_SpareRecordsId",
                        column: x => x.SpareRecordsId,
                        principalTable: "ServiceRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairDetail_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairDetail_SparePartsId",
                table: "RepairDetail",
                column: "SparePartsId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairDetail_SpareRecordsId",
                table: "RepairDetail",
                column: "SpareRecordsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairDetail");
        }
    }
}
