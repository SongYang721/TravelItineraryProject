using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class NewImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c71487f-7118-4041-ab5a-730a0b5b46a9", "AQAAAAIAAYagAAAAEDFYYhvAOQAOmIpT6izvkJkzk00Umv7EwYo3Nf29vWp8tWWSEimXf247KzmUBFxHYQ==", "ded75ee5-3e4a-4d79-a395-1ac3250a268f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02e6d00-b4b0-4a62-8675-0bc8fecb988a", "AQAAAAIAAYagAAAAEI1ot/k3aqHEKuB7EW75RYEHcaUrTR0k7sHz2FYKYVGy3rZsMPg8a4tM+5OQ/HN6mQ==", "90164cf8-9000-4bac-97af-2ebce067904c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5731f160-766d-4547-8cbe-5fd00ad45e86", "AQAAAAIAAYagAAAAEGgUBj2MVgJDcXAg7pZdEuTt6zL9J09CRkqZOD+8kFocYwmsOCwKuBxvLzKMl+8Jdg==", "f63f1a7b-2e78-4bc3-9659-24ba8b68e454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff1225f-1a8c-47e4-8d0a-b9d23ebabff2", "AQAAAAIAAYagAAAAEJqeqcmzbyZJonoAIG7KLRH28R/PJzBIQUX9YAovKtH5LKvj/5PymCVwY3sWRPlXHA==", "e7543b61-6048-4943-b56d-4da1675c0fef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf00dc3-6ab1-435d-be3f-3990e1254390", "AQAAAAIAAYagAAAAEOSAg2C2Upb0WeIG+n3vPj1mJj/AGgiHq2IFg5OmHDyCymlqvP0T8QzrZ2wRHksSSg==", "74fc08a7-5200-4417-b03e-1bec7a654690" });

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 1,
                column: "ImageUrl",
                value: "Images/JapanItinerary.jpg");

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 2,
                column: "ImageUrl",
                value: "Images/Taiwan.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://www.google.com/imgres?q=photo%20of%20leisure%20japan&imgurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fwp-content%2Fuploads%2F2024%2F10%2FLeisure-Japan.jpg&imgrefurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fnews%2Farticle%2Fleisure-japan-2024-to-showcase-in-tokyo-highlighting-innovations-in-theme-parks-and-sustainable-travel-from-october-16-18%2F&docid=oDDXWdoS4OBMmM&tbnid=-EKiPmzqiZi-DM&vet=12ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA..i&w=830&h=646&hcb=2&ved=2ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA");

            migrationBuilder.UpdateData(
                table: "Itinerary",
                keyColumn: "ItineraryId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.google.com/url?sa=i&url=https%3A%2F%2Fneocha.com%2Fmagazine%2Ftaiwan-then-now%2F&psig=AOvVaw09-bgY1IEvtpAp6qmoelo-&ust=1739266532110000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCMju7PHmuIsDFQAAAAAdAAAAABAE");
        }
    }
}
