using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVarBookingDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "SelectedDateRange",
                table: "Booking");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5a919fa-dd59-46bc-8e79-cd1323c64277", "AQAAAAIAAYagAAAAEGsFVRFBv33dnYKlYhjgrXNm3GpismSTVO/HpM/fx10D8ylSdRhfIPbcKcMs8LfS1w==", "75d83bf3-e9fa-49a0-92ff-991e85affcc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca6f184-30b0-4401-9fee-cea3233aa81c", "AQAAAAIAAYagAAAAEGVEVdGNVKL0Q9ennZrcNrxUhPr5d5koswlLS43O6GYLgTOQzv9/6TZ9i5VMLqKcxA==", "7d9b9172-c8aa-4651-9ec7-41928fce4b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26cd533a-7ed0-4157-a51b-37be0173a04f", "AQAAAAIAAYagAAAAEKOobMkFajvBUvcZ2alCgppml9cGulIYM192vH39otBYy0vXlZRwShl5WUHMpkzZ0Q==", "ee483393-ce20-4a76-bff1-1d2ca0f1ed89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65720f65-e3df-444f-95e7-a1d2fcd59423", "AQAAAAIAAYagAAAAEBGNvnboUZGb9WE0VsONGjKGKs3CnNKxZSKE+uCwefM7bwj7hBnLkJZUbDo70i8hDA==", "43cc35b7-71d5-4476-afff-53fb6354b9bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec872986-f6da-410c-8b98-85ac03af8395", "AQAAAAIAAYagAAAAEMvcefRXaDWgpsFk6yrvYvP2YiM+bCNDJCshA+2vgiJckPBhv95Y/38rZdXNZesLkg==", "a36f8bf4-84a2-40fe-943f-9d71c22db672" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "BookingDate",
                table: "Booking",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "SelectedDateRange",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f2cbfbd-81ef-47d8-a2bd-bd030dc75c28", "AQAAAAIAAYagAAAAEFvetGB+0Ky3S8oQNO05opR05QESvIZ+46xtcdjpPbVO47SeUmLRiaYkc2WdYuAGUA==", "5b440863-27a9-4dd1-8478-403546b15030" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f02bc4-84c4-46c8-9508-652dd2393a92", "AQAAAAIAAYagAAAAECJsStSLMsSO2cUVlsuf7o2HtGZ8Cnc/LYO9EBp0AJdK23wa23uX1EhZIGMPe85QMQ==", "beba671c-fa71-4ac2-afd2-b01257138e43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05907bbc-8dc1-437f-b821-af173546cad9", "AQAAAAIAAYagAAAAEJa24bs+E7yzmoNC7g8JFytk/+bJyDJTR+kKYqUBZA0uLjzOcbQWjPWqlCB9PkLbrw==", "43a01d85-2cf0-48d0-9373-176c0cb01f68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0a74482-ed4c-41fe-abee-6f39dbda3860", "AQAAAAIAAYagAAAAEB2qFL6YBwCePxKAZUs43F4YnmjfGg1BbwNJFoej69FRaL5yq1hsKKJn5ZZMNUI1PQ==", "5877376f-ddad-498f-b811-2ced9c6180b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c60191-bd95-4373-9461-41229a108e35", "AQAAAAIAAYagAAAAEB+Hn8NVg87TLnyKfs+uHtHuxdrKZPscKOf109uXRvEw9MWBMsuIVt7JzVyt8/9SuA==", "94e073e8-3f97-4d07-9db7-98c7b1897730" });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 1,
                columns: new[] { "BookingDate", "SelectedDateRange" },
                values: new object[] { new DateOnly(2024, 1, 3), null });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "BookingId",
                keyValue: 2,
                columns: new[] { "BookingDate", "SelectedDateRange" },
                values: new object[] { new DateOnly(2025, 8, 2), null });
        }
    }
}
