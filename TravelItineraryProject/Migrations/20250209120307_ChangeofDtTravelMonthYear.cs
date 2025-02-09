using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class ChangeofDtTravelMonthYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestTravelMonthYear",
                table: "ItineraryRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33114f84-1eaf-4f8c-be6d-4813beb66d2e", "AQAAAAIAAYagAAAAEFbQhYxYA/lFPKdOl5SNTKoq/M3Dhcjs47krZdHMwUj+QgLt42Ei0Ta0bVAPZn5u9Q==", "fa897c5e-c6f8-44ce-99ca-41c5290003ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9a02e7a-ff66-4863-8910-2aa411275717", "AQAAAAIAAYagAAAAEGyWGz4nMr74n82M5ox/b5TFLNnWN7PX6WbiPqcAiqk8jvZV8SBpeEktSXQWrtNxRA==", "e7737679-4f8a-47ed-9515-f53d5f6f926b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2deac6d6-2081-46ee-a5a0-a3d337fc7087", "AQAAAAIAAYagAAAAECL9MHGyxpZPEVBV5KwR2ErXqaTRLNOWK0C0PNfXt9cfKXovNGxd+WyovB0AGlbHug==", "46eb286f-31e2-44fd-881e-e55512b2c5b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69f5d629-b3bc-48b2-9b83-7f6b9cc3f40e", "AQAAAAIAAYagAAAAEOnr3Tpr0R2L2Jh2t5vbqnp0lomgJun5dw6H4d2E/gsE9Pjmw3aVpi23YCMIAt+N3Q==", "2e811938-df69-485c-81eb-8ff84b21ed6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b624ca0-825a-4c58-a11d-494c3533388c", "AQAAAAIAAYagAAAAECEzMJ19ZrIgc/mw6f+zzfWz0ztbUpYTYbXkFJkvOD63m8rictfGWf1w19iLGOj/MA==", "1a3af767-60f5-4c7c-93bc-c224112f5caf" });

            migrationBuilder.UpdateData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 1,
                column: "RequestTravelMonthYear",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 2,
                column: "RequestTravelMonthYear",
                value: new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestTravelMonthYear",
                table: "ItineraryRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0051178f-1515-41f6-bc28-e7cc94cf0036", "AQAAAAIAAYagAAAAEBM1UcKye417NlMyUIwQRqgH7cMlN1HJY97GcXkquRQV6TrSM/Z/YCNnSnj8Fq+b8Q==", "04b6074f-0a81-4d45-a5ab-722d9c0952df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0988890f-8c10-44b8-8695-9268517fc30e", "AQAAAAIAAYagAAAAEN8TmspPoauml8QJZ0v/+l8Dc2yCGcWE3bLoCw2vphfhSU4lsW0VFBW4Qi+01rJhgw==", "694a5a9a-b940-40d1-abc5-654d89e5e4ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7682d618-c582-44df-8188-814ce1a1393a", "AQAAAAIAAYagAAAAEHBkNi2oZ82W/dhDkOQzht6qk7tcZGCeQ702DuOC+C80y4/x5suwjYxHHe+eEiXlZA==", "e9875f26-3450-4dac-b3d7-7d87871b64e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2600068a-934e-45db-8cc1-ae3bb500e88b", "AQAAAAIAAYagAAAAEOQHQvtXBBdqJI92qYWXwPXRZzKU4tfmgvqgUv6Fvgou4Zis/w8EvzsjlFJHYFHN1A==", "9857ddbd-5803-4b4a-a1fc-6da19b9a1d4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c2e89ef-e465-4d91-8d0c-721d1a6862b1", "AQAAAAIAAYagAAAAEPBtABQ3+cUAFweUKmZLNeOaBEdEjfQsIt4RzzXOF5gvuVwcJ1kIgzSS5gMW5p0bJw==", "90aa2b0c-a619-4dd7-b46b-9dadb974aea3" });

            migrationBuilder.UpdateData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 1,
                column: "RequestTravelMonthYear",
                value: "January 2024");

            migrationBuilder.UpdateData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 2,
                column: "RequestTravelMonthYear",
                value: "August 2025");
        }
    }
}
