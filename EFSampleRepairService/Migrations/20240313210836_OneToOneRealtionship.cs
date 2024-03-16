using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRealtionship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ServiceRecordId",
                table: "Invoices",
                newName: "ServiceRecordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceRecordsId",
                table: "Invoices",
                column: "ServiceRecordsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordsId",
                table: "Invoices",
                column: "ServiceRecordsId",
                principalTable: "ServiceRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordsId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ServiceRecordsId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ServiceRecordsId",
                table: "Invoices",
                newName: "ServiceRecordId");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordId",
                table: "Invoices",
                column: "ServiceRecordId",
                principalTable: "ServiceRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
