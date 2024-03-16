using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Invoices_InvoicesId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_InvoicesId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "InvoicesId",
                table: "ServiceRecords");

            migrationBuilder.AddColumn<int>(
                name: "ServiceRecordId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_ServiceRecords_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ServiceRecordId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ServiceRecordId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "InvoicesId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_InvoicesId",
                table: "ServiceRecords",
                column: "InvoicesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Invoices_InvoicesId",
                table: "ServiceRecords",
                column: "InvoicesId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
