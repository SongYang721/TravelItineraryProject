using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class ReAddedDateRange : Migration
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
                values: new object[] { "8c78d885-bd30-4c9a-9d66-0f521f934628", "AQAAAAIAAYagAAAAEEaphRFb2Z8kps8iTTa3wAPdoHEjnlbaOk9JtWghRO1FKNybAWkEENUvr6vXOVDKng==", "8ff522aa-4baf-4cda-86b7-050eaa299d86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85a3b71e-a7f2-4570-b6fe-04dcafeb3482", "AQAAAAIAAYagAAAAEIXBeYfzC7UyOXpwfTxk4//cNov3DW8EigKvmJ8rR3kJeu+BPwpXzGedjuIkiOZuPg==", "7de84b5d-cc5b-4405-837f-70551bf3fcc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70dd506f-77b5-4e58-b6ac-8e5ba77c6f0b", "AQAAAAIAAYagAAAAEO4U6r6ClymMj7IY+eb12hAe1Wu/nRfFwYUni3Qp6THTWi+9upFSf2a/k1joxfylAA==", "265ab935-4e45-47f4-a4ae-5c65b6910fe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17545fef-ed5d-45d9-a189-be682bc42252", "AQAAAAIAAYagAAAAEMO72RsJyOcFpq5KSia18ekZecZBSmtDSpkOk9X1I0mfgb2m2arAnj9urKhIQQT6IQ==", "d2d4f0c6-e2f6-465d-9329-27d0cc596967" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce9011b-9403-4bbc-b332-131760d5ebaa", "AQAAAAIAAYagAAAAEP/GLf4hoL+T5xFRoETtc8mihEozx75LN5KL+ISDY/NahlvCFHsD8+/hAKVL3Wz6oQ==", "35725589-edb8-47f6-8190-d9e50747ec77" });

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
