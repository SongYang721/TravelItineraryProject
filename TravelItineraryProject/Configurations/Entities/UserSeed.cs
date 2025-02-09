using TravelItineraryProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;
namespace TravelItineraryProject.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<TravelItineraryProjectUser>
    {
        public void Configure(EntityTypeBuilder<TravelItineraryProjectUser> builder)
        {
            var hasher = new PasswordHasher<TravelItineraryProjectUser>();
            builder.HasData(
            new TravelItineraryProjectUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new TravelItineraryProjectUser
            {
                Id = "10e93995-24eb-48b5-805b-824adeb6fb96",
                Email = "alicejohnson@gmail.com",
                NormalizedEmail = "alicejohnson@gmail.com",
                FirstName = "Alice",
                LastName = "Johnson",
                UserName = "alicejohnson@gmail.com",
                NormalizedUserName = "ALICEJOHNSON@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true, // Set to true, otherwise you won't be able to login
                StaffId = 1
            },
            new TravelItineraryProjectUser
            {
                Id = "f272bf94-a1ab-451a-b55a-0e68638d6bb4",
                Email = "bobsmith@gmail.com",
                NormalizedEmail = "bobsmith@gmail.com",
                FirstName = "Bob",
                LastName = "Smith",
                UserName = "bobsmith@gmail.com",
                NormalizedUserName = "BOBSMITH@GMAIL.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true, // Set to true, otherwise you won't be able to login
                StaffId = 2
            },
            new TravelItineraryProjectUser
            {
                Id = "4fd66d43-0660-4dc0-a96e-f83b593e4175",
                Email = "johndoe@example.com",
                NormalizedEmail = "johndoe@example.com",
                FirstName = "John",
                LastName = "Doe",
                UserName = "johndoe@example.com",
                NormalizedUserName = "JOHNDOE@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true, // Set to true, otherwise you won't be able to login
                CustomerId = 1
            },
            new TravelItineraryProjectUser
            {
                Id = "f8b82324-d7ce-4578-9b88-2b6d693b72de",
                Email = "janesmith@example.com",
                NormalizedEmail = "janesmith@example.com",
                FirstName = "Jane",
                LastName = "Smith",
                UserName = "janesmith@example.com",
                NormalizedUserName = "JANESMITH@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true, // Set to true, otherwise you won't be able to login
                CustomerId = 2
            }
            );
        }
    }
}