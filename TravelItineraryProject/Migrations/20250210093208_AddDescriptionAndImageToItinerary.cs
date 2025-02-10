using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionAndImageToItinerary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Itinerary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Itinerary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e091c8d6-0d82-46dc-a95e-a72f0fab362d", "AQAAAAIAAYagAAAAEGC1JWGK9s+h84XmCSTiszo3kLyDpNJZdryswr8Hn07mI3+REOpcytFoTnv9EJj97g==", "8b0c16b4-9377-47eb-8910-a4aeea899b1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2935822e-18ec-4cb7-ac1d-0db5655a729e", "AQAAAAIAAYagAAAAEEwG0xOibAUq08hnRcfDPYyU0WR5MVDS9qYfrIsRrbxmemc715g/WxN34W1+iBE88g==", "5375816b-b4c2-4a5b-8761-9387500b6200" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fe6f265-6d80-4af1-93d2-eeaf3363aaa4", "AQAAAAIAAYagAAAAENTM+d8MIPv9e+qzU+R0oXxk11VNJUwUk3HAfrM3oacFKwnzgZfHplnFFkVADFyaoQ==", "b9a89f2d-a03d-4b6f-9446-4cecbc4fced3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61c8d119-1663-4132-a379-6d0bd7a4b70b", "AQAAAAIAAYagAAAAEMMQ4YGP8hWCoS9EUrYTUXn5Wp1eu+9jcAcpfuh2MiJHhBp9AeCVgH8QuXs2srKt+w==", "99d35f1c-380c-421a-86fc-01b2aeaa626a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95dc2c34-bac0-47ad-8668-b49865831b9b", "AQAAAAIAAYagAAAAEMtaeORc8m0flAmWXiWCd0HeOZ3WItWaMrswHY1ACCpINReDCCk638HGlPgEddMW1A==", "f72442cc-5e36-4b26-8ab7-edc68c7fe415" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Itinerary");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Itinerary");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d9d1e9-6ccc-4b0f-b9f6-217d1456a444", "AQAAAAIAAYagAAAAEJ4MZ2wpRgfdrCy3prksLhnRY+IzZBGj3AGKi1XJHJ103G/Fcgtpfl5jLlVDlSpa3A==", "3a865c1f-bb9c-45ee-b565-a926326d2493" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a98ab9-d80e-439f-b390-c7bfc14ebf8d", "AQAAAAIAAYagAAAAEJhFhoWUOsBKfLzr/ozVWDhmEBryzUYaj7ZQzcTgsVPjPX1MSwa2CopriGmZA5Wu8g==", "107cc06b-c695-4187-bacb-30348af14b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78f476a0-b3d0-491a-a9a2-17cec0d19305", "AQAAAAIAAYagAAAAEABUeBtVSUfrSj6L9q3CJV3MJfimNHUittCavq52OpS8iLusJb7HN7jyxDkPgKKyfA==", "77641827-3963-46ed-b70a-eb230231a525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55a1a4d-0ed5-403b-9c43-0c84ca28b7d6", "AQAAAAIAAYagAAAAENw1WPK5VBmioBHoynbv6rDoZK9t9X55xuNKdr/8oMqfSs+tygkYdf492DoPUDAoOQ==", "61d1302c-b33f-44b5-af9b-0850b8d72da9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "674047a1-0852-4a63-9772-50fc8cc6d1e7", "AQAAAAIAAYagAAAAEB3jZw2WODIHvaW8jDkwxxksBu4GMpaMBgmMR3UivR2h0WOkiKgWJiXdZrDVmu9LEA==", "579f9d59-cbee-44fe-8ed0-120eba02a1e6" });
        }
    }
}
