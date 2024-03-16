using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordsTAbleColumnUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServiceStatusId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_ServiceStatusId",
                table: "ServiceRecords",
                column: "ServiceStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_ServiceStatusId",
                table: "ServiceRecords",
                column: "ServiceStatusId",
                principalTable: "ServiceStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_ServiceStatus_ServiceStatusId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_ServiceStatusId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "ServiceStatusId",
                table: "ServiceRecords");
        }
    }
}
