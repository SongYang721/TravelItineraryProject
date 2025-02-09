using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class updateIRTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa9e57d-8d9c-4fba-a840-615c19844652", "AQAAAAIAAYagAAAAEMHoV5qwXBJw3kwhmQbd17ZirhvsmlMyVftTzKd52uJFLri4CP1o+funK5AGFPCEbw==", "7f6b71e2-1732-4c57-ac81-26f6e4615083" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "503a9208-e1ea-4b22-8801-98d67cfd86bb", "AQAAAAIAAYagAAAAEEjqtPmLqCA7vERSbUKFMUBAdQwt3N/337I3KcrV5fiH5MfUT2YSHSFKnQ/pXJB5ww==", "f68816ae-924f-4c0c-9938-fc5e685cf98e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a03a19bb-5ca8-4191-97aa-bf2768c66166", "AQAAAAIAAYagAAAAEOWGcDUMwskdmphdR9ya3S6vcVg27I3huKYTXpXbaRmnsy/9I6ym928LzMk56b9Glg==", "e0c0294e-2fa5-487e-86e0-75f48c652c97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b801d93-0d41-4157-a559-0ea5958d2ea1", "AQAAAAIAAYagAAAAEFbK0N+bQUpNKBisSYiK4hQayU1ptQgedCWuA8INhbpp/Lw009SR0Bts2H19ko4f8Q==", "be0cffab-7e98-44b4-9808-40c759d2a1cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b559da-65d8-44f7-b1cf-a5a68dddbfea", "AQAAAAIAAYagAAAAEL0NR33hpPEppu5jacXUl5Na4r0htzVWj2zx/fL0EdkFxnlNRIjSTLv47IFYgZyAXg==", "c536053b-d49c-459d-a69f-9492206fa47c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
