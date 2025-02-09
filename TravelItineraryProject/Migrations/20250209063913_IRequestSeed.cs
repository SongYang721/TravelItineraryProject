using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class IRequestSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ItineraryRequest",
                columns: new[] { "ItineraryRequestId", "CustomerId", "Destination", "NumberOfRequests", "RequestApproval", "RequestTravelMonthYear", "StaffId", "TypeOfTrip" },
                values: new object[,]
                {
                    { 1, 1, "Paris, France", 1, false, "January 2024", 1, "History" },
                    { 2, 2, "Tokyo, Japan", 20, false, "August 2025", 2, "Vacation" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItineraryRequest",
                keyColumn: "ItineraryRequestId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af2e2f7b-1fbc-43cb-8f50-401d0f877636", "AQAAAAIAAYagAAAAEKtVAKr8Os8wfcKgxxLfIH3pCR8Al57glB7AmhMCEjT561Y6miY82Fe2aulpe9ygsA==", "7a98ad72-6225-4085-b6f2-e02318bc2899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bbb1183-5d7d-4787-b4a8-fa7d5057cdc9", "AQAAAAIAAYagAAAAEEvcvOd1V1YWHwhiwhk3+t1iYfxWxf5sKPWHKO95tJFgQJJpQCElNtTqF4Eeya5T+w==", "cd690fba-5a14-4317-b2b8-ec28a827c9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "671d3e59-e668-45c3-a52a-4700e4eb62dc", "AQAAAAIAAYagAAAAEHlkKzxFIPZQc8L/0x/q5ky9sHKZJfxCf1auILU360KpGoiADCqKDYO3iaHCYjLPLA==", "634231f9-e584-46d3-9905-2ae5cbba874e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5105cd0e-9314-44ad-bf9c-4c28cc7eee0e", "AQAAAAIAAYagAAAAEKuuPxTW7uBl1VQO2GLpP0Oyi3fwkkAP7pl1aUSHs+jI/mngbJGNqOjdzwDNsNuO9Q==", "c2c500d0-f246-461f-a095-65fe378a5668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7edf7c58-18f1-4426-b1df-3c26e7a4a52e", "AQAAAAIAAYagAAAAEJx3rx6SviI8j1rRiqXROOW6E72xAaJVjNvZhiA2xxQ5dT7UBeL7HchZMyf+iygk7Q==", "1a5395fd-278c-4185-b4bc-67885de5e16b" });
        }
    }
}
