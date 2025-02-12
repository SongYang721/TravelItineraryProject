using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelectedDateRange",
                table: "Booking",
                type: "nvarchar(255)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d78b7a01-c3f2-486e-85fa-be01530d1855", "AQAAAAIAAYagAAAAEH5CCxo4BoBQalj3EXfyA3fxWXUTutJofAaLjQiAZo1lira1iuVnRmg2aOxdptA1Gg==", "1199c18b-a896-452e-ac1d-347664f06109" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f1114e5-9364-46ff-9424-d0f4faa0b877", "AQAAAAIAAYagAAAAEC2q4gQOpo3Ui826fzg6eUF+iLxlXHWAjxzb4l6QC0kkThN2pylGHCdvGNPR0PtS5w==", "1d090486-43ed-403c-b0fc-262e6fef98e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "521916d3-1599-4976-97a3-31c948d1f7ac", "AQAAAAIAAYagAAAAEMJ7jucjL/MT7VDAJQHVMs7UBAib7TsG7gOnSqHJOxFHjzV2sZX/3zbLCs1jLgG92A==", "3029d9d5-f19a-4d94-8032-738fa9721a62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54f97df-ff2e-453c-aef7-a679a5ed5371", "AQAAAAIAAYagAAAAEMWx34UJdlDngpT84T61aXZIrtfeU3jMNzc3URkY+GnQTTzFRrzDPdkJTPW3VdLqiA==", "9a43d395-5f9a-4c96-ac3e-e765ad680cd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63275c45-1441-4e89-a880-db76c6831489", "AQAAAAIAAYagAAAAEJq1tHqGxWUBAFuvQs2qWZoEodIgQ+vRd3G4ohYhJpLiI276exDVFO0AaL7eluXEpg==", "b55d60e6-1924-4524-9547-34422bdcff17" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "SelectedDateRange",
                value: "14-16 February");

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "SelectedDateRange",
                value: "16-18 February");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedDateRange",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d091358b-4925-4f59-b6fc-0cef67060df0", "AQAAAAIAAYagAAAAEATKRrHn41E3yCt8ILFY/Lk1xLaX04UTaORLOLTfA3b/KaL/UgE1cf+WxoWjac2TEg==", "924431dc-bf47-47fe-8811-b74951ea7c8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2322dd-11ff-4581-935c-e0696d553f84", "AQAAAAIAAYagAAAAENDr1l/0F4YYdWr2bAJiLsHIqn9MQr18jeqY6gJZpUc82pNzp2TibdyT8UBRIcMQ5w==", "55deca69-2dcc-425f-a778-b91650901949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5539f3cb-c144-4a8b-9efe-1424a37208fb", "AQAAAAIAAYagAAAAEGKfESWfHO8gcquZkC5TZdMsOH/0q4Ntp7Pi85vPDoXRg5SUfMchfVLv5YEwje34AQ==", "1409b2ec-0153-46b2-87e1-fc914b573828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65cbfffa-9d9a-49e3-9108-2466bff4ddde", "AQAAAAIAAYagAAAAEDs9u4Nl6TyKnA8joNfVNwAe6Ur8YAxTr5bAo6fnNBK5zpHO2idsrKAhVaie8/0wug==", "449c2ab8-040d-488b-8cf9-ea2802021d65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21d1171e-ae83-4757-ae81-08f89df51f15", "AQAAAAIAAYagAAAAEI4DMAMOgLUpbHHDSednG251nS4E3MyNP/Ub8WHzxLfhVXYc9SeMVzqiyXJViNNxGg==", "ac4f1e9d-e6f2-42eb-b096-54c6223602fd" });
        }
    }
}
