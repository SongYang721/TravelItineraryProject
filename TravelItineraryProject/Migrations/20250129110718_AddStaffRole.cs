using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddStaffRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ApprovedByStaff",
                table: "Review",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PaymentStatus",
                table: "Payment",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Staff", "STAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a78dfe3-3323-4b38-8ccf-9919fd33a29f", "AQAAAAIAAYagAAAAENgitZDtNLlq+9byVLN8Yk7UIlI9m8epLw4cFWOv+3dFx3ttLdCkb0vNYKKiCLQHfg==", "f10a03d6-372c-42af-b262-4d2232d7752e" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 1,
                column: "Email",
                value: "staff1@gmail.com");

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "StaffId",
                keyValue: 2,
                column: "Email",
                value: "staff2@gmail.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staff");

            migrationBuilder.AlterColumn<bool>(
                name: "ApprovedByStaff",
                table: "Review",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "PaymentStatus",
                table: "Payment",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef25d428-fd6f-436c-8927-2f2f1e743757", "AQAAAAIAAYagAAAAEI3TNTP49fH543T1y+fur3uAlsJCX6Ne5UZGh1TZ1Qcv2/Y7N1tVejSqhPvSkHWReQ==", "6de07a36-c429-4d5c-93b5-5574cf2c28cb" });
        }
    }
}
