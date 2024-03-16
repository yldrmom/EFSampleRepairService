using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class SpareDetailsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiveRecordsId",
                table: "RepairDetail");

            migrationBuilder.DropColumn(
                name: "SparePartId",
                table: "RepairDetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiveRecordsId",
                table: "RepairDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SparePartId",
                table: "RepairDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
