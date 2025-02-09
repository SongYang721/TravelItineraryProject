using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class fixreview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_UserId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Review",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Review",
                newName: "IX_Review_CustomerId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Review",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4de6d5c-f2bc-414c-8c26-358ddd54e162", "AQAAAAIAAYagAAAAELor2Cy0/E557FNII3hJ7GJ2Cw6SOSX0S05ZdJMpX2eOj0HJA0dRhRfbJnf+m8xvOA==", "67b2be44-9657-454f-bcf3-d90680274660" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f429d845-62f0-4751-87a1-c4735410508c", "AQAAAAIAAYagAAAAEAUcP+J2ZZqlVc6AylUZPLdviAPnLPYDiiBFs1vzEuWcZcAqLo6+/7DudEdZ5EGJng==", "06d31384-fa4f-4d68-af1e-1c39dbe84120" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e121de-39ef-4048-ac09-e5b71493bec5", "AQAAAAIAAYagAAAAEP1QMOfsQAkdNMLIApeyXhjKpcvnUNAsQ1Bea8ZGvgeuQpUx+XwEEAJfXjMep5jNXg==", "c098a111-c893-490d-b84e-7471953d637f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5ce814-762a-42c5-9483-ce418d3fed18", "AQAAAAIAAYagAAAAELo+ABjHPQAcMD/s4NLBiWrsq6iQNYeW8WyZ3Ac62ETcGj5kxlAXXgT86PfTiN5RoA==", "ae911001-6271-4f7c-91ef-70e983a57e67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55f41387-e7fa-455a-be16-286c4cf61bd3", "AQAAAAIAAYagAAAAEAobSrD8NUmK5eZf6Lrfi0yiWYUPkG1/z0FWkj1qgmWgjS8Oz8RAhU11R4qSqtobcQ==", "6c049fbf-7191-4537-8845-463337e3ce96" });

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
