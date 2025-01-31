using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;

namespace TravelItineraryProject.Configurations.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    StaffId = 1,
                    Password = "hashedPassword123", // Ensure this is a hashed password in real scenarios
                    Name = "Alice Johnson",
                    Email = "staff1@gmail.com"

                },
                new Staff
                {
                    StaffId = 2,
                    Password = "hashedPassword456", // Ensure this is a hashed password in real scenarios
                    Name = "Bob Smith",
                    Email = "staff2@gmail.com"
                }
            );
        }
    }
}
