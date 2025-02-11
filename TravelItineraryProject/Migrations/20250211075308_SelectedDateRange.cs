using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class SelectedDateRange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameOnCard",
                table: "Payment",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDateOfCard",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvailableDateRanges",
                table: "Itinerary",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SelectedDateRange",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f2cbfbd-81ef-47d8-a2bd-bd030dc75c28", "AQAAAAIAAYagAAAAEFvetGB+0Ky3S8oQNO05opR05QESvIZ+46xtcdjpPbVO47SeUmLRiaYkc2WdYuAGUA==", "5b440863-27a9-4dd1-8478-403546b15030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f02bc4-84c4-46c8-9508-652dd2393a92", "AQAAAAIAAYagAAAAECJsStSLMsSO2cUVlsuf7o2HtGZ8Cnc/LYO9EBp0AJdK23wa23uX1EhZIGMPe85QMQ==", "beba671c-fa71-4ac2-afd2-b01257138e43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05907bbc-8dc1-437f-b821-af173546cad9", "AQAAAAIAAYagAAAAEJa24bs+E7yzmoNC7g8JFytk/+bJyDJTR+kKYqUBZA0uLjzOcbQWjPWqlCB9PkLbrw==", "43a01d85-2cf0-48d0-9373-176c0cb01f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a74482-ed4c-41fe-abee-6f39dbda3860", "AQAAAAIAAYagAAAAEB2qFL6YBwCePxKAZUs43F4YnmjfGg1BbwNJFoej69FRaL5yq1hsKKJn5ZZMNUI1PQ==", "5877376f-ddad-498f-b811-2ced9c6180b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c60191-bd95-4373-9461-41229a108e35", "AQAAAAIAAYagAAAAEB+Hn8NVg87TLnyKfs+uHtHuxdrKZPscKOf109uXRvEw9MWBMsuIVt7JzVyt8/9SuA==", "94e073e8-3f97-4d07-9db7-98c7b1897730" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "SelectedDateRange",
                value: null);

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "SelectedDateRange",
                value: null);

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 1,
                column: "AvailableDateRanges",
                value: "14-16 February, 16-18 February");

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 2,
                column: "AvailableDateRanges",
                value: "14-16 February, 16-18 February");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableDateRanges",
                table: "Itinerary");

            migrationBuilder.DropColumn(
                name: "SelectedDateRange",
                table: "Booking");

            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NameOnCard",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDateOfCard",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "467a1a5b-be86-4c98-9e36-e1e22ad9bf5b", "AQAAAAIAAYagAAAAEKwp4jPSfYM0IA+bzdHVmoT53Wo0cT5Sj8ILSz8vpAyEzVvbmF9+sVw/41GPyKZtSg==", "5055adf4-ee0b-468c-a5a5-946c9576ff63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bedd1403-f8ed-4089-bf6d-98a3c75cb60c", "AQAAAAIAAYagAAAAEFcA8zKpcTdfrr/obvpHBD5VojCZZ8NeCmZIkUnXqHGu7+YEI5BfJnySj5xHn8OHkw==", "27a7d537-19ae-47e2-a0b4-e11360f78afc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59ca1813-917f-4bdd-8b44-1164d57e95d0", "AQAAAAIAAYagAAAAEI8RBrAfU3fLj3LEF14Gd1A4+5ik1YHRmdvd6R+S/j1z6QBGtTAlNJYQ0ELtk8IIJA==", "c2e28848-2d5d-4d69-b61a-546d92a99e8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f33e3fde-778e-4056-bae1-55c11be3ad52", "AQAAAAIAAYagAAAAEE3gr0J3Liip/HjcEZv75DVNAHCMVu6Y25GlxZu25F8Q8xidLMFy1mFmO89mEUrA/g==", "87b18802-b9e8-4407-88ef-fa0c1f65e79e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0da61427-fd8f-42de-bd11-894db13a68e5", "AQAAAAIAAYagAAAAELYD2EQNpsNt/uVv/rGFT1CWBCn8rsrd7EWdTAbfHYaDWUxfEESVQeV6YokTUvJMJA==", "32ec1734-5c01-40b1-9b23-a97d78e1e433" });
        }
    }
}
