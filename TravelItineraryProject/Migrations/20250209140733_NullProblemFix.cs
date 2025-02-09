using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class NullProblemFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61af8c4d-18b7-4f9d-b134-62b5a81ca0dc", "AQAAAAIAAYagAAAAEJijturl2kfn3hLWOJbrm4mcDtAVhuNXMVLshfYJQGMKE3XZAg277t0e0Zk5eCSmSw==", "cfa6cdae-d9ae-49b4-a24a-a5beaeacc3f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75377a93-afed-4060-9e3a-f8f58267295d", "AQAAAAIAAYagAAAAEBR5fizhNQ1USjDxJ1JADtkFeKDhXSlk6l6C/wJhJO1cUzmlBirnKMyPThbceyYpoQ==", "2d623d9a-24e6-42c3-bc4d-9ad399e3edcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb80ca74-ac7c-4f5a-99d2-e6013747a39c", "AQAAAAIAAYagAAAAEKCr5K/0wtoRsAq7mclyQe3aCWQecdfY4HX+gH187B6HZX2OxhHcQEZGoLPx45a8Fg==", "faedad74-62e7-47bd-8f40-a6839b472851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6efcd1f9-69aa-4eb3-85ab-d6df9a6af3d8", "AQAAAAIAAYagAAAAEFnZsircvboBJabEwqcrqKuLRy3Kcp2ecHyZPa638olGzKtnSXpgpn3jaHusC8Olnw==", "24433988-71bf-43bc-bf2c-777ae3a82dbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e081945e-ea43-4e17-aeea-a45f4368bab0", "AQAAAAIAAYagAAAAEDuadpSc+blAkvBg7nmF2oZ53GHlXC+Zygo9UzcTQiw6TMcAXOSnNtecnzjMOARhkQ==", "d86e0e91-943a-4839-9d4c-210c53405b1e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c159ac6f-d498-46de-bfae-d9b6a5753152", "AQAAAAIAAYagAAAAELNThXBNEF4hbNZ4KCVQpHMwMTxDTz97Gib6n6i1uTqkfJ1kp1zp7p+uClXb/eXBsA==", "634aa0fe-9e9b-4814-bbca-074501f86bc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c50a1f9-c2a2-497d-9852-809f148160a6", "AQAAAAIAAYagAAAAEOKSi3dBDP/rBzVLYd5vUwWn+EsLK9uXKN0cZ5e4pqZU7+ajrEL+2lNbeZZTe8tynw==", "2858c93e-af63-44a6-99c4-f93cfd8cb6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10f41c40-e73f-4194-8342-2092da676962", "AQAAAAIAAYagAAAAENUIjvuDKR3MjhhG3tML/5KEDVeR/3qKDR2N61A5cajTtZ5Zgb6PaNd07JQP92f5pg==", "aca954f0-6281-4bc8-86b1-6b386b4eda87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11b3cc71-c924-443b-8a7f-5b9940551444", "AQAAAAIAAYagAAAAEIoiI+3rZXY/Xv49UhHEadkgSLHKcnuE5DeBwZHP+7G44S/k5jfi9/bwqD+Vdly7tQ==", "b136df45-7bff-4ae8-bb64-72103039154a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "681666e1-6bdd-4f57-bd57-8febcaf650c8", "AQAAAAIAAYagAAAAEOsyVYYwaJf3+xAW3Zpjq6wJ4beMCDtE55h3smVcO5Ldr81OxEnkiokp3h8Yf2pjEg==", "385339a3-23bc-44a7-a264-5222e29c7066" });
        }
    }
}
