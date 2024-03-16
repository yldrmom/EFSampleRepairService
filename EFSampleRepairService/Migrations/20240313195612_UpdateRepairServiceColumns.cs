using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFSampleRepairService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRepairServiceColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeriNumber",
                table: "ServiceRecords",
                newName: "SerialNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceRecords",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "ServiceRecords",
                newName: "SeriNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceRecords",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
