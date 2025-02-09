using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class nullproblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Itinerary_ItineraryId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItineraryId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd133f27-af3c-4903-9595-361c7657c860", "AQAAAAIAAYagAAAAEGrTJWPAmmaza4U6Njj+nRK7n3ksTfsXXhLjKxqdJwd413VjFGJKCVA9M9bdidyRyQ==", "b926fb0a-a951-45fd-87c2-af152935ff35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a58bc34b-76d3-42df-a6c1-798f5f06fbeb", "AQAAAAIAAYagAAAAEASCPIPTYVR8e520RYqjTU9DrzfObKpt0j7UMehk5+ORfdM9B8k/cLsWN9Cl4Bxptg==", "8712c377-aed7-4699-820b-4b87c07947ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838a5a38-3bac-4de1-bd0f-0f7d073b8e5d", "AQAAAAIAAYagAAAAEPnUUELdA7vZz7uQoI+B7lz1zHLjOZeNH3K4PPW45G/sZJ/d/1DUGCG/trfBNT4A3g==", "121461d8-47ce-43c4-8a4a-8496e11c66cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92430c39-a132-4e6e-a6b4-7aab20029a05", "AQAAAAIAAYagAAAAEABpPGzWNlWscDgGEesG7uATKpMvAPwcJqY3PGaNvwBDwzCUY+kRlBZrftgNcwVnWQ==", "015dfd02-fc17-454a-9438-fde4d3267b7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad4b6d43-72f1-4071-861e-c20330e168ce", "AQAAAAIAAYagAAAAEKCI0Y/3YMq6aPlz32IjFV6kY50SbwWWmHl3Du7xxs7ddVpp+pV4PJg4Ui9Z59mL3A==", "8b5c3c5b-86ea-4598-90d5-0b3ec3763e9a" });

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Itinerary_ItineraryId",
                table: "Review",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Itinerary_ItineraryId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "StaffId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItineraryId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Review",
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
                values: new object[] { "aa342958-570c-4d28-a291-02a3b4c43f85", "AQAAAAIAAYagAAAAEBRGrraChmYE7ovSkJQF+iUqV9BcV9ReTm0k/1vo951nOM7oADrnG8zKTdsyVgHiqA==", "6fe08b50-937f-42aa-b5fa-e0c7d3fe31a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c3e0dd4-ffb6-4ea3-96d8-768182bdaad4", "AQAAAAIAAYagAAAAEAFY5zSZhfciUA9uBL/Zz5CtkcUVqtobH0S4+l6RDzypBLKoWN5fceedNSGViQFQAQ==", "cd139159-2df0-471c-ba0a-fe4d1e32da17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "941f4af7-58a7-4190-8bbf-17c3581379ba", "AQAAAAIAAYagAAAAEDVOyWTbbCbaL10s2bThKYBHgqowJ4liqlDkAQBXPhO9SqfJnzQUyjysR/uCs0801Q==", "eefdac85-4dba-4b86-be55-19df35816fe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56ee87e0-d335-40aa-b602-bdd13a4e0ca7", "AQAAAAIAAYagAAAAEFnnhtsY4dVdlD/XA9ktxdMwmYtzWrtOhTa4hwsYheYSQrudTYw2aQXJX+ekAmTqZA==", "fdb1c595-8152-4630-b258-f9292536d86b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc4af4ee-5698-4030-a852-0227824b7bf2", "AQAAAAIAAYagAAAAEI4n6YRh5MoOIevcAl94MwLi/ERd39XtjOYrkHRLY6DsHq1SH3J4pZUoeqpWPOedKw==", "25495b4b-edf3-4bca-b7a0-cb9a46fdebb0" });

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Itinerary_ItineraryId",
                table: "Review",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
