using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10e93995-24eb-48b5-805b-824adeb6fb96",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d091358b-4925-4f59-b6fc-0cef67060df0", "AQAAAAIAAYagAAAAEATKRrHn41E3yCt8ILFY/Lk1xLaX04UTaORLOLTfA3b/KaL/UgE1cf+WxoWjac2TEg==", "924431dc-bf47-47fe-8811-b74951ea7c8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2322dd-11ff-4581-935c-e0696d553f84", "AQAAAAIAAYagAAAAENDr1l/0F4YYdWr2bAJiLsHIqn9MQr18jeqY6gJZpUc82pNzp2TibdyT8UBRIcMQ5w==", "55deca69-2dcc-425f-a778-b91650901949" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5539f3cb-c144-4a8b-9efe-1424a37208fb", "AQAAAAIAAYagAAAAEGKfESWfHO8gcquZkC5TZdMsOH/0q4Ntp7Pi85vPDoXRg5SUfMchfVLv5YEwje34AQ==", "1409b2ec-0153-46b2-87e1-fc914b573828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65cbfffa-9d9a-49e3-9108-2466bff4ddde", "AQAAAAIAAYagAAAAEDs9u4Nl6TyKnA8joNfVNwAe6Ur8YAxTr5bAo6fnNBK5zpHO2idsrKAhVaie8/0wug==", "449c2ab8-040d-488b-8cf9-ea2802021d65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21d1171e-ae83-4757-ae81-08f89df51f15", "AQAAAAIAAYagAAAAEI4DMAMOgLUpbHHDSednG251nS4E3MyNP/Ub8WHzxLfhVXYc9SeMVzqiyXJViNNxGg==", "ac4f1e9d-e6f2-42eb-b096-54c6223602fd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
