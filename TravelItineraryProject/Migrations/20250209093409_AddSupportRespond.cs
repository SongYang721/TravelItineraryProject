using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class AddSupportRespond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Responds",
                table: "SupportRequest",
                type: "nvarchar(max)",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Responds",
                table: "SupportRequest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41143a7d-c6fc-4e77-97d2-4520befba8c2", "AQAAAAIAAYagAAAAEHFvXVB/dzsJhyuyF93TCxKB6FrCH12Wd/Stf8c0jE9kCXyLoHAgQ1IMPOGeNz6pnw==", "8851cf81-b2be-4fe1-a905-d003ffb3503b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9311b8d0-eb8a-4f95-a31e-9157be1fa8a7", "AQAAAAIAAYagAAAAEL8yhue5UfQA9EQj4HT42mEt/0S2C0yrsXirmF7YagnotascA55GcsTlqfNI6g/4sQ==", "8e703d94-ece8-4902-9eac-9bcc6c26fc1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36b6ee0f-46dc-4aed-bec4-d742626b6f21", "AQAAAAIAAYagAAAAECb+bLvz2v/E5GLIeIkYiaUL/PbPPuFTS7YpmQRDZuBHBKlZeq7DSV2rlDz2FANLvA==", "1542e119-5539-46de-81ac-85991d7fede7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bbb2ab3-2a15-4b69-835e-64a9badd6ed6", "AQAAAAIAAYagAAAAEIJLvVTa/1a2einIeT15KOF/61pmJgp5+jZOXtEYobprxurZWHUvM8Cat6XC/M0zMQ==", "b79fabe4-31e3-4d4b-8bc2-33b6e7481754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1e0caa6-cbeb-42d5-8375-5f1ea6df1b62", "AQAAAAIAAYagAAAAEFoV04cTfa/0ApqqgO1Gjlhb1+bh/PJjd1WvOUT72dVwITyJRoPRzvXsW59A/++A9w==", "d31f99b9-483b-48b9-b4ac-4871c3cab572" });
        }
    }
}
