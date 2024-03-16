using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class ServiceRecordsPersonelIdUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personel_ServiceRecords_ServiceRecordsId",
                table: "Personel");

            migrationBuilder.DropIndex(
                name: "IX_Personel_ServiceRecordsId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "ServiceRecordsId",
                table: "Personel");

            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "ServiceRecords",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServiceRecords_PersonelId",
                table: "ServiceRecords",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceRecords_Personel_PersonelId",
                table: "ServiceRecords",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceRecords_Personel_PersonelId",
                table: "ServiceRecords");

            migrationBuilder.DropIndex(
                name: "IX_ServiceRecords_PersonelId",
                table: "ServiceRecords");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "ServiceRecords");

            migrationBuilder.AddColumn<int>(
                name: "ServiceRecordsId",
                table: "Personel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personel_ServiceRecordsId",
                table: "Personel",
                column: "ServiceRecordsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_ServiceRecords_ServiceRecordsId",
                table: "Personel",
                column: "ServiceRecordsId",
                principalTable: "ServiceRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
