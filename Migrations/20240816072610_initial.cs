using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AR_VehicleServiceCenter.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Payments_PaymentId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Vehicles_VehicleId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceId1",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Appointments_AppointmentId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Appointments_AppointmentId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_AppointmentId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Services_AppointmentId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Payments_InvoiceId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_VehicleId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "InvoiceId1",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "colour",
                table: "Vehicles",
                newName: "Colour");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Services",
                newName: "Price");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Invoices",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ServiceId",
                table: "Invoices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Payments_PaymentId",
                table: "Appointments",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "PaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Services_ServiceId",
                table: "Invoices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Appointments_VehicleId",
                table: "Vehicles",
                column: "VehicleId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Payments_PaymentId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Services_ServiceId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Appointments_VehicleId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ServiceId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "Colour",
                table: "Vehicles",
                newName: "colour");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Services",
                newName: "price");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvoiceId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId1",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AppointmentId",
                table: "Vehicles",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_AppointmentId",
                table: "Services",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InvoiceId1",
                table: "Payments",
                column: "InvoiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_VehicleId",
                table: "Appointments",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Payments_PaymentId",
                table: "Appointments",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Vehicles_VehicleId",
                table: "Appointments",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "VehicleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceId",
                table: "Payments",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceId1",
                table: "Payments",
                column: "InvoiceId1",
                principalTable: "Invoices",
                principalColumn: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Appointments_AppointmentId",
                table: "Services",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Appointments_AppointmentId",
                table: "Vehicles",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "AppointmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
