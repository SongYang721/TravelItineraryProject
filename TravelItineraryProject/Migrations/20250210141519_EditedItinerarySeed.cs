using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class EditedItinerarySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Experience the best of Japan at a leisurely pace, blending serene natural beauty, cultural exploration, and indulgent relaxation. Perfect for those looking to unwind and immerse themselves in the tranquil charm of Japan", "https://www.google.com/imgres?q=photo%20of%20leisure%20japan&imgurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fwp-content%2Fuploads%2F2024%2F10%2FLeisure-Japan.jpg&imgrefurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fnews%2Farticle%2Fleisure-japan-2024-to-showcase-in-tokyo-highlighting-innovations-in-theme-parks-and-sustainable-travel-from-october-16-18%2F&docid=oDDXWdoS4OBMmM&tbnid=-EKiPmzqiZi-DM&vet=12ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA..i&w=830&h=646&hcb=2&ved=2ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Discover the rich history and culture of Taiwan, from ancient temples to bustling night markets. This itinerary is perfect for history buffs and foodies alike, offering a taste of Taiwan's diverse heritage and culinary delights.", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fneocha.com%2Fmagazine%2Ftaiwan-then-now%2F&psig=AOvVaw09-bgY1IEvtpAp6qmoelo-&ust=1739266532110000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCMju7PHmuIsDFQAAAAAdAAAAABAE" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
