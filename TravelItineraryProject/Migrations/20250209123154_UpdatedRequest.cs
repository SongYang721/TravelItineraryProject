using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestTravelMonthYear",
                table: "ItineraryRequest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c069d6-f79b-4e41-af33-609d94523704", "AQAAAAIAAYagAAAAEK/Inm4W484qhAesRE+cJTWn6sVdOc7eB3q08yQaFjzKjxcew5h73rrThHmgR7pxVA==", "ba4e917a-fb48-4516-8012-bf7f18ccd762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67b521f2-aa4d-44b9-8d54-b3568263d6b0", "AQAAAAIAAYagAAAAEK+CVetrTIPKRsDBwLaDy0ouqUkF4wXCtEWrwqBQvesE1QYdVdZ+y7/qco1ffVfbaA==", "9e4ced1c-1adf-4641-84c5-8888eb4f27e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98c698a7-d0ae-41a8-8c4b-642ba1ca5638", "AQAAAAIAAYagAAAAEIoxOpM1YRjkq+1+k94EAS/WrIsgTxcJFwiFcHjB/sOX5OxnIWfq4B0KUud+zJP58g==", "1847aa88-0bad-4383-ba37-85e3e4327045" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b90403b-3a21-443b-824d-15d28640956a", "AQAAAAIAAYagAAAAECgUnQyuDK62nOM00Ve1c9KZkA99mmz7ld4SAKdf8IAXbW1k1bAeuHC1BMVhjaMjRA==", "6975a3c1-bb67-4769-957c-9c305c31ec1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c0a1c2a-f39e-4fde-9100-bcf105127094", "AQAAAAIAAYagAAAAEE18/lps6ZheS3i8ziJAdQqnn41ntGW7A5meVVuv8LclTIp+C7UGZsB5Kj1nni7nJg==", "c506c27a-2cab-4f2a-84fb-f354964a03fa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RequestTravelMonthYear",
                table: "ItineraryRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
