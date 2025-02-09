using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedingofSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportRequest_Customer_CustomerId",
                table: "SupportRequest");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "SupportRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.InsertData(
                table: "SupportRequest",
                columns: new[] { "SupportRequestId", "Assisted", "Comments", "CustomerId", "Responds", "StaffId", "TypeofSupport" },
                values: new object[,]
                {
                    { 1, false, "My booking was denied even though payment went through", 2, null, null, "Payment Issues" },
                    { 2, false, "I would like to cancel my booking as i can't make it anymore on that date.", 1, null, null, "Cancel of Booking" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SupportRequest_Customer_CustomerId",
                table: "SupportRequest",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupportRequest_Customer_CustomerId",
                table: "SupportRequest");

            migrationBuilder.DeleteData(
                table: "SupportRequest",
                keyColumn: "SupportRequestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SupportRequest",
                keyColumn: "SupportRequestId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "SupportRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71de108c-8254-4671-a87d-5555604a4de8", "AQAAAAIAAYagAAAAEBsLPgXTMfJ1AsP0v/zdE3zuBsOGXqLEsMir4ZkjLTPViBd9sXmyHrkICu6FyN9Caw==", "41610491-b001-4282-8f3c-cb184d1a070b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91fdb643-386f-4f11-8164-adff7c400e00", "AQAAAAIAAYagAAAAEAJKtilEMtZirZgxiJtVHjRCVZVnddBjO4UjUc1Lnzq3qk7Z3I1+8xXUI96ymffzng==", "94f0241a-bf46-42b3-a8a0-b2b405df5233" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79f34e2f-d09e-48c4-ba89-36c8654c7640", "AQAAAAIAAYagAAAAEDDLY8h312Kx6lJzm29JcepaKOvdOlt5yHQ9jleEGtSa+exWv7v3JJ7YzZtHW0e1kQ==", "7439e62a-9994-4858-aea2-b189dbe03ea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d899f05c-9e29-41e0-b6da-addc8ef0d739", "AQAAAAIAAYagAAAAEFBgBNh35cj7nnHQHRE0t/C1JYWDhjU6mrbweUROa9lvXWOrlPVOgcNZsuRdaDcWiw==", "e7927f92-fa89-439e-a959-332ac314b4d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e76810c-75fb-4162-a9f5-3279465a1fb8", "AQAAAAIAAYagAAAAEM0iwqkKbfxF6ju/AAhDv6UIF17853VFgJJ2YkmbKqTeqBUVgWJPZS+g+ZYSpFqimg==", "02ecc737-a039-4935-ae79-19b041f9126b" });

            migrationBuilder.AddForeignKey(
                name: "FK_SupportRequest_Customer_CustomerId",
                table: "SupportRequest",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
