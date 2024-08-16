using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AR_VehicleServiceCenter.Migrations
{
    /// <inheritdoc />
    public partial class twelve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_CustomerUserId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_CustomerId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Vehicles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_CustomerId",
                table: "Vehicles",
                newName: "IX_Vehicles_UserId");

            migrationBuilder.RenameColumn(
                name: "CustomerUserId",
                table: "Admins",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_CustomerUserId",
                table: "Admins",
                newName: "IX_Admins_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_UserId",
                table: "Vehicles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_UserId",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_UserId",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Vehicles",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles",
                newName: "IX_Vehicles_CustomerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Admins",
                newName: "CustomerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                newName: "IX_Admins_CustomerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_CustomerUserId",
                table: "Admins",
                column: "CustomerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
