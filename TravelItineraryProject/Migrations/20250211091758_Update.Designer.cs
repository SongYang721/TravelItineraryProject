﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelItineraryProject.Data;

#nullable disable

namespace TravelItineraryProject.Migrations
{
    [DbContext(typeof(TravelItineraryProjectContext))]
    [Migration("20250211091758_Update")]
    partial class Update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "cd2bcf0c-20db-474f-8407-5a6b159518bc",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                        },
                        new
                        {
                            UserId = "10e93995-24eb-48b5-805b-824adeb6fb96",
                            RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518bc"
                        },
                        new
                        {
                            UserId = "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                            RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518bc"
                        },
                        new
                        {
                            UserId = "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                            RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb"
                        },
                        new
                        {
                            UserId = "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                            RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TravelItineraryProject.Data.TravelItineraryProjectUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5a2322dd-11ff-4581-935c-e0696d553f84",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENDr1l/0F4YYdWr2bAJiLsHIqn9MQr18jeqY6gJZpUc82pNzp2TibdyT8UBRIcMQ5w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "55deca69-2dcc-425f-a778-b91650901949",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        },
                        new
                        {
                            Id = "10e93995-24eb-48b5-805b-824adeb6fb96",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d091358b-4925-4f59-b6fc-0cef67060df0",
                            Email = "alicejohnson@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Alice",
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            NormalizedEmail = "alicejohnson@gmail.com",
                            NormalizedUserName = "ALICEJOHNSON@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEATKRrHn41E3yCt8ILFY/Lk1xLaX04UTaORLOLTfA3b/KaL/UgE1cf+WxoWjac2TEg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "924431dc-bf47-47fe-8811-b74951ea7c8b",
                            StaffId = 1,
                            TwoFactorEnabled = false,
                            UserName = "alicejohnson@gmail.com"
                        },
                        new
                        {
                            Id = "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "65cbfffa-9d9a-49e3-9108-2466bff4ddde",
                            Email = "bobsmith@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Bob",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "bobsmith@gmail.com",
                            NormalizedUserName = "BOBSMITH@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDs9u4Nl6TyKnA8joNfVNwAe6Ur8YAxTr5bAo6fnNBK5zpHO2idsrKAhVaie8/0wug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "449c2ab8-040d-488b-8cf9-ea2802021d65",
                            StaffId = 2,
                            TwoFactorEnabled = false,
                            UserName = "bobsmith@gmail.com"
                        },
                        new
                        {
                            Id = "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5539f3cb-c144-4a8b-9efe-1424a37208fb",
                            CustomerId = 1,
                            Email = "johndoe@example.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "johndoe@example.com",
                            NormalizedUserName = "JOHNDOE@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGKfESWfHO8gcquZkC5TZdMsOH/0q4Ntp7Pi85vPDoXRg5SUfMchfVLv5YEwje34AQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1409b2ec-0153-46b2-87e1-fc914b573828",
                            TwoFactorEnabled = false,
                            UserName = "johndoe@example.com"
                        },
                        new
                        {
                            Id = "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "21d1171e-ae83-4757-ae81-08f89df51f15",
                            CustomerId = 2,
                            Email = "janesmith@example.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "janesmith@example.com",
                            NormalizedUserName = "JANESMITH@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI4DMAMOgLUpbHHDSednG251nS4E3MyNP/Ub8WHzxLfhVXYc9SeMVzqiyXJViNNxGg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ac4f1e9d-e6f2-42eb-b096-54c6223602fd",
                            TwoFactorEnabled = false,
                            UserName = "janesmith@example.com"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<bool>("BookingStatus")
                        .HasColumnType("bit");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ItineraryId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("StaffId");

                    b.ToTable("Booking");

                    b.HasData(
                        new
                        {
                            BookingId = 1,
                            BookingStatus = false,
                            CustomerId = 1,
                            ItineraryId = 1,
                            PaymentId = 1,
                            StaffId = 1
                        },
                        new
                        {
                            BookingId = 2,
                            BookingStatus = false,
                            CustomerId = 2,
                            ItineraryId = 2,
                            PaymentId = 2,
                            StaffId = 2
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            EmailAddress = "johndoe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            CustomerId = 2,
                            EmailAddress = "janesmith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Itinerary", b =>
                {
                    b.Property<int>("ItineraryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItineraryId"));

                    b.Property<string>("AvailableDateRanges")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("PromotionAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeofTrip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItineraryId");

                    b.HasIndex("StaffId");

                    b.ToTable("Itinerary");

                    b.HasData(
                        new
                        {
                            ItineraryId = 1,
                            AvailableDateRanges = "14-16 February, 16-18 February",
                            Description = "Experience the best of Japan at a leisurely pace, blending serene natural beauty, cultural exploration, and indulgent relaxation. Perfect for those looking to unwind and immerse themselves in the tranquil charm of Japan",
                            Duration = 7,
                            ImageUrl = "https://www.google.com/imgres?q=photo%20of%20leisure%20japan&imgurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fwp-content%2Fuploads%2F2024%2F10%2FLeisure-Japan.jpg&imgrefurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fnews%2Farticle%2Fleisure-japan-2024-to-showcase-in-tokyo-highlighting-innovations-in-theme-parks-and-sustainable-travel-from-october-16-18%2F&docid=oDDXWdoS4OBMmM&tbnid=-EKiPmzqiZi-DM&vet=12ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA..i&w=830&h=646&hcb=2&ved=2ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA",
                            Price = 963m,
                            PromotionAvailable = false,
                            StaffId = 2,
                            Title = "Japan",
                            TypeofTrip = "Leisure"
                        },
                        new
                        {
                            ItineraryId = 2,
                            AvailableDateRanges = "14-16 February, 16-18 February",
                            Description = "Discover the rich history and culture of Taiwan, from ancient temples to bustling night markets. This itinerary is perfect for history buffs and foodies alike, offering a taste of Taiwan's diverse heritage and culinary delights.",
                            Duration = 6,
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fneocha.com%2Fmagazine%2Ftaiwan-then-now%2F&psig=AOvVaw09-bgY1IEvtpAp6qmoelo-&ust=1739266532110000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCMju7PHmuIsDFQAAAAAdAAAAABAE",
                            Price = 873m,
                            PromotionAvailable = true,
                            StaffId = 1,
                            Title = "Taiwan",
                            TypeofTrip = "Historical"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.ItineraryRequest", b =>
                {
                    b.Property<int>("ItineraryRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItineraryRequestId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfRequests")
                        .HasColumnType("int");

                    b.Property<bool>("RequestApproval")
                        .HasColumnType("bit");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfTrip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItineraryRequestId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StaffId");

                    b.ToTable("ItineraryRequest");

                    b.HasData(
                        new
                        {
                            ItineraryRequestId = 1,
                            CustomerId = 1,
                            Destination = "Paris, France",
                            NumberOfRequests = 1,
                            RequestApproval = false,
                            StaffId = 1,
                            TypeOfTrip = "History"
                        },
                        new
                        {
                            ItineraryRequestId = 2,
                            CustomerId = 2,
                            Destination = "Tokyo, Japan",
                            NumberOfRequests = 20,
                            RequestApproval = false,
                            StaffId = 2,
                            TypeOfTrip = "Vacation"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExpiryDateOfCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            CardNumber = "1234567812345678",
                            ExpiryDateOfCard = "12-25",
                            NameOnCard = "John Doe",
                            PaymentStatus = true,
                            SecurityCode = "123"
                        },
                        new
                        {
                            PaymentId = 2,
                            CardNumber = "2345678923456789",
                            ExpiryDateOfCard = "11-24",
                            NameOnCard = "Jane Smith",
                            PaymentStatus = false,
                            SecurityCode = "456"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<bool>("ApprovedByStaff")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ItineraryId")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ItineraryId");

                    b.HasIndex("StaffId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            ApprovedByStaff = true,
                            Comment = "Excellent experience!",
                            CustomerId = 1,
                            ItineraryId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 1
                        },
                        new
                        {
                            ReviewId = 2,
                            ApprovedByStaff = false,
                            Comment = "Great service, but could improve the food quality.",
                            CustomerId = 2,
                            ItineraryId = 2,
                            Rating = 4,
                            ReviewDate = new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StaffId = 2
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            Email = "alicejohnson@gmail.com",
                            Name = "Alice Johnson"
                        },
                        new
                        {
                            StaffId = 2,
                            Email = "bobsmith@gmail.com",
                            Name = "Bob Smith"
                        });
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.SupportRequest", b =>
                {
                    b.Property<int>("SupportRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupportRequestId"));

                    b.Property<bool>("Assisted")
                        .HasColumnType("bit");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Responds")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("TypeofSupport")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupportRequestId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StaffId");

                    b.ToTable("SupportRequest");

                    b.HasData(
                        new
                        {
                            SupportRequestId = 1,
                            Assisted = false,
                            Comments = "My booking was denied even though payment went through",
                            CustomerId = 2,
                            TypeofSupport = "Payment Issues"
                        },
                        new
                        {
                            SupportRequestId = 2,
                            Assisted = false,
                            Comments = "I would like to cancel my booking as i can't make it anymore on that date.",
                            CustomerId = 1,
                            TypeofSupport = "Cancel of Booking"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TravelItineraryProject.Data.TravelItineraryProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TravelItineraryProject.Data.TravelItineraryProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelItineraryProject.Data.TravelItineraryProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TravelItineraryProject.Data.TravelItineraryProjectUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Booking", b =>
                {
                    b.HasOne("TravelItineraryProject.Domain.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TravelItineraryProject.Domain.Itinerary", "Itinerary")
                        .WithMany("Bookings")
                        .HasForeignKey("ItineraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelItineraryProject.Domain.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelItineraryProject.Domain.Staff", "Staff")
                        .WithMany("Bookings")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Customer");

                    b.Navigation("Itinerary");

                    b.Navigation("Payment");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Itinerary", b =>
                {
                    b.HasOne("TravelItineraryProject.Domain.Staff", "Staff")
                        .WithMany("Itineraries")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.ItineraryRequest", b =>
                {
                    b.HasOne("TravelItineraryProject.Domain.Customer", "Customer")
                        .WithMany("ItineraryRequests")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TravelItineraryProject.Domain.Staff", "Staff")
                        .WithMany("ItineraryRequests")
                        .HasForeignKey("StaffId");

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Review", b =>
                {
                    b.HasOne("TravelItineraryProject.Domain.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TravelItineraryProject.Domain.Itinerary", "Itinerary")
                        .WithMany()
                        .HasForeignKey("ItineraryId");

                    b.HasOne("TravelItineraryProject.Domain.Staff", "Staff")
                        .WithMany("Reviews")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Customer");

                    b.Navigation("Itinerary");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.SupportRequest", b =>
                {
                    b.HasOne("TravelItineraryProject.Domain.Customer", "Customer")
                        .WithMany("SupportRequests")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TravelItineraryProject.Domain.Staff", "Staff")
                        .WithMany("SupportRequests")
                        .HasForeignKey("StaffId");

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("ItineraryRequests");

                    b.Navigation("Reviews");

                    b.Navigation("SupportRequests");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Itinerary", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("TravelItineraryProject.Domain.Staff", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Itineraries");

                    b.Navigation("ItineraryRequests");

                    b.Navigation("Reviews");

                    b.Navigation("SupportRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
