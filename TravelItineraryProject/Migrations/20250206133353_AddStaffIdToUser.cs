using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddStaffIdToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "BookingStatus",
                table: "Booking",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4570c2d4-98c2-4e9b-9f3e-ee770d1cacbc", "AQAAAAIAAYagAAAAED+xHB2ktqPHqgb+gk+xIEoMh6B97k3cvmspplsMxjR5IMCnVtrRe6Vwf2BtqD9B5A==", "61787079-13a2-4f5c-8e5f-9ad2a8d83400" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "BookingStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "BookingStatus",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "BookingStatus",
                table: "Booking",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e7f00a9-f66d-4eb5-80f4-a325d75b1302", "AQAAAAIAAYagAAAAEHvGKLQ8ZpHhoMiViGnbtsA/vOIePkCizog7HXixGptNUiHIX2v09NXn7xk2iUXhKQ==", "35a5ba8c-0110-49e2-a1a0-87827402225a" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "BookingStatus",
                value: null);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "BookingStatus",
                value: null);
        }
    }
}
