using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AssignStaffRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "10e93995-24eb-48b5-805b-824adeb6fb96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67be4ddc-deed-44b7-b18e-ce20a20c414f", "AQAAAAIAAYagAAAAENH0Kqz+AXt5rGWXQGgeXAnv3Vt489oKKI3qdfFH0mlZHTWEhmIxB5ULt9nFsLnfGQ==", "72386630-bb49-44e6-8536-3ab6e86c9d9d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "10e93995-24eb-48b5-805b-824adeb6fb96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a78dfe3-3323-4b38-8ccf-9919fd33a29f", "AQAAAAIAAYagAAAAENgitZDtNLlq+9byVLN8Yk7UIlI9m8epLw4cFWOv+3dFx3ttLdCkb0vNYKKiCLQHfg==", "f10a03d6-372c-42af-b262-4d2232d7752e" });
        }
    }
}
