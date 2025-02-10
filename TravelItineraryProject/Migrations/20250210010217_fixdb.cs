using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelItineraryProject.Migrations
{
    /// <inheritdoc />
    public partial class fixdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOnCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDateOfCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Itinerary",
                columns: table => new
                {
                    ItineraryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PromotionAvailable = table.Column<bool>(type: "bit", nullable: false),
                    TypeofTrip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itinerary", x => x.ItineraryId);
                    table.ForeignKey(
                        name: "FK_Itinerary_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItineraryRequest",
                columns: table => new
                {
                    ItineraryRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestApproval = table.Column<bool>(type: "bit", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfTrip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRequests = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryRequest", x => x.ItineraryRequestId);
                    table.ForeignKey(
                        name: "FK_ItineraryRequest_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItineraryRequest_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "SupportRequest",
                columns: table => new
                {
                    SupportRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assisted = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeofSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportRequest", x => x.SupportRequestId);
                    table.ForeignKey(
                        name: "FK_SupportRequest_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_SupportRequest_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingStatus = table.Column<bool>(type: "bit", nullable: false),
                    BookingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    ItineraryId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Booking_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "ItineraryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedByStaff = table.Column<bool>(type: "bit", nullable: false),
                    ItineraryId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Review_Itinerary_ItineraryId",
                        column: x => x.ItineraryId,
                        principalTable: "Itinerary",
                        principalColumn: "ItineraryId");
                    table.ForeignKey(
                        name: "FK_Review_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10e93995-24eb-48b5-805b-824adeb6fb96", 0, "c7d9d1e9-6ccc-4b0f-b9f6-217d1456a444", null, "alicejohnson@gmail.com", true, "Alice", "Johnson", false, null, "alicejohnson@gmail.com", "ALICEJOHNSON@GMAIL.COM", "AQAAAAIAAYagAAAAEJ4MZ2wpRgfdrCy3prksLhnRY+IzZBGj3AGKi1XJHJ103G/Fcgtpfl5jLlVDlSpa3A==", null, false, "3a865c1f-bb9c-45ee-b565-a926326d2493", 1, false, "alicejohnson@gmail.com" },
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b4a98ab9-d80e-439f-b390-c7bfc14ebf8d", null, "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJhFhoWUOsBKfLzr/ozVWDhmEBryzUYaj7ZQzcTgsVPjPX1MSwa2CopriGmZA5Wu8g==", null, false, "107cc06b-c695-4187-bacb-30348af14b8d", null, false, "admin@localhost.com" },
                    { "4fd66d43-0660-4dc0-a96e-f83b593e4175", 0, "78f476a0-b3d0-491a-a9a2-17cec0d19305", 1, "johndoe@example.com", true, "John", "Doe", false, null, "johndoe@example.com", "JOHNDOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEABUeBtVSUfrSj6L9q3CJV3MJfimNHUittCavq52OpS8iLusJb7HN7jyxDkPgKKyfA==", null, false, "77641827-3963-46ed-b70a-eb230231a525", null, false, "johndoe@example.com" },
                    { "f272bf94-a1ab-451a-b55a-0e68638d6bb4", 0, "b55a1a4d-0ed5-403b-9c43-0c84ca28b7d6", null, "bobsmith@gmail.com", true, "Bob", "Smith", false, null, "bobsmith@gmail.com", "BOBSMITH@GMAIL.COM", "AQAAAAIAAYagAAAAENw1WPK5VBmioBHoynbv6rDoZK9t9X55xuNKdr/8oMqfSs+tygkYdf492DoPUDAoOQ==", null, false, "61d1302c-b33f-44b5-af9b-0850b8d72da9", 2, false, "bobsmith@gmail.com" },
                    { "f8b82324-d7ce-4578-9b88-2b6d693b72de", 0, "674047a1-0852-4a63-9772-50fc8cc6d1e7", 2, "janesmith@example.com", true, "Jane", "Smith", false, null, "janesmith@example.com", "JANESMITH@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB3jZw2WODIHvaW8jDkwxxksBu4GMpaMBgmMR3UivR2h0WOkiKgWJiXdZrDVmu9LEA==", null, false, "579f9d59-cbee-44fe-8ed0-120eba02a1e6", null, false, "janesmith@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "johndoe@example.com", "John", "Doe" },
                    { 2, "janesmith@example.com", "Jane", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "CardNumber", "ExpiryDateOfCard", "NameOnCard", "PaymentStatus", "SecurityCode" },
                values: new object[,]
                {
                    { 1, "1234567812345678", "12-25", "John Doe", true, "123" },
                    { 2, "2345678923456789", "11-24", "Jane Smith", false, "456" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "alicejohnson@gmail.com", "Alice Johnson" },
                    { 2, "bobsmith@gmail.com", "Bob Smith" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "10e93995-24eb-48b5-805b-824adeb6fb96" },
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "4fd66d43-0660-4dc0-a96e-f83b593e4175" },
                    { "cd2bcf0c-20db-474f-8407-5a6b159518bc", "f272bf94-a1ab-451a-b55a-0e68638d6bb4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f8b82324-d7ce-4578-9b88-2b6d693b72de" }
                });

            migrationBuilder.InsertData(
                table: "Itinerary",
                columns: new[] { "ItineraryId", "Duration", "Price", "PromotionAvailable", "StaffId", "Title", "TypeofTrip" },
                values: new object[,]
                {
                    { 1, 7, 963m, false, 2, "Japan", "Leisure" },
                    { 2, 6, 873m, true, 1, "Taiwan", "Historical" }
                });

            migrationBuilder.InsertData(
                table: "ItineraryRequest",
                columns: new[] { "ItineraryRequestId", "CustomerId", "Destination", "NumberOfRequests", "RequestApproval", "StaffId", "TypeOfTrip" },
                values: new object[,]
                {
                    { 1, 1, "Paris, France", 1, false, 1, "History" },
                    { 2, 2, "Tokyo, Japan", 20, false, 2, "Vacation" }
                });

            migrationBuilder.InsertData(
                table: "SupportRequest",
                columns: new[] { "SupportRequestId", "Assisted", "Comments", "CustomerId", "Responds", "StaffId", "TypeofSupport" },
                values: new object[,]
                {
                    { 1, false, "My booking was denied even though payment went through", 2, null, null, "Payment Issues" },
                    { 2, false, "I would like to cancel my booking as i can't make it anymore on that date.", 1, null, null, "Cancel of Booking" }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "BookingDate", "BookingStatus", "CustomerId", "ItineraryId", "PaymentId", "StaffId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 1, 3), false, 1, 1, 1, 1 },
                    { 2, new DateOnly(2025, 8, 2), false, 2, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "ApprovedByStaff", "Comment", "CustomerId", "ItineraryId", "Rating", "ReviewDate", "StaffId" },
                values: new object[,]
                {
                    { 1, true, "Excellent experience!", 1, 1, 5, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, false, "Great service, but could improve the food quality.", 2, 2, 4, new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ItineraryId",
                table: "Booking",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PaymentId",
                table: "Booking",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_StaffId",
                table: "Booking",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Itinerary_StaffId",
                table: "Itinerary",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryRequest_CustomerId",
                table: "ItineraryRequest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryRequest_StaffId",
                table: "ItineraryRequest",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ItineraryId",
                table: "Review",
                column: "ItineraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_StaffId",
                table: "Review",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequest_CustomerId",
                table: "SupportRequest",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportRequest_StaffId",
                table: "SupportRequest",
                column: "StaffId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "ItineraryRequest");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "SupportRequest");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Itinerary");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
