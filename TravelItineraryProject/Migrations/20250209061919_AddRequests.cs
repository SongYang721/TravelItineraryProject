using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfRequests",
                table: "ItineraryRequest",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28545f2a-1c83-449c-9172-7c758d2c38b2", "AQAAAAIAAYagAAAAEPd7AIO/lTjiffD8ccqo5WDBtRilW0cOw9qhEOMXjgJL2IDqdlz7+2ust3+Uz4R0MQ==", "b5d5a57e-1cc2-4ed8-9c7e-26d71e7d7b89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c273a25f-478f-42f1-86f0-210e04b0171f", "AQAAAAIAAYagAAAAEGiQak5oRt5WPWohIxUzgXzkw8TMkXrEkgdg+hxNyCWSunumXik7cVPWhZ5oOmhydg==", "dbb55b94-c59f-454e-a762-50732a5f12fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1408a24-03a1-44de-a377-35fefadae0c9", "AQAAAAIAAYagAAAAEF2u1/Nhhx+TBMnjCWhiezq5hCHzOTp6LbSpJkVaJu+36TFzrjMelM0pEkhvuQc9+A==", "4ec9f92f-6df9-485d-810d-d14ca86912bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce62657-8a7b-430b-8985-ac7568bf973e", "AQAAAAIAAYagAAAAEJT9nklHckb/CR8YZUfFG79LLAef4GkHOXYSn635iFxYXQ2Dnu/jF+s82fTqgj0gdA==", "10c14c10-f623-4ea2-95ba-91b882c41098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f51a755-9e5e-4294-af1e-c8a3f3c64c93", "AQAAAAIAAYagAAAAEE1+VlyvvJDdnaKVvcvcxm+FeiIGZI7s634TgwhG6JmUGSCLBb+VQIlWHV9arVbT1w==", "f60854a0-ffe5-4c4c-a395-bb450ca5eae9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRequests",
                table: "ItineraryRequest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41143a7d-c6fc-4e77-97d2-4520befba8c2", "AQAAAAIAAYagAAAAEHFvXVB/dzsJhyuyF93TCxKB6FrCH12Wd/Stf8c0jE9kCXyLoHAgQ1IMPOGeNz6pnw==", "8851cf81-b2be-4fe1-a905-d003ffb3503b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9311b8d0-eb8a-4f95-a31e-9157be1fa8a7", "AQAAAAIAAYagAAAAEL8yhue5UfQA9EQj4HT42mEt/0S2C0yrsXirmF7YagnotascA55GcsTlqfNI6g/4sQ==", "8e703d94-ece8-4902-9eac-9bcc6c26fc1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36b6ee0f-46dc-4aed-bec4-d742626b6f21", "AQAAAAIAAYagAAAAECb+bLvz2v/E5GLIeIkYiaUL/PbPPuFTS7YpmQRDZuBHBKlZeq7DSV2rlDz2FANLvA==", "1542e119-5539-46de-81ac-85991d7fede7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bbb2ab3-2a15-4b69-835e-64a9badd6ed6", "AQAAAAIAAYagAAAAEIJLvVTa/1a2einIeT15KOF/61pmJgp5+jZOXtEYobprxurZWHUvM8Cat6XC/M0zMQ==", "b79fabe4-31e3-4d4b-8bc2-33b6e7481754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e0caa6-cbeb-42d5-8375-5f1ea6df1b62", "AQAAAAIAAYagAAAAEFoV04cTfa/0ApqqgO1Gjlhb1+bh/PJjd1WvOUT72dVwITyJRoPRzvXsW59A/++A9w==", "d31f99b9-483b-48b9-b4ac-4871c3cab572" });
        }
    }
}
