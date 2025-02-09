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
                    Name = "Alice Johnson",
                    Email = "alicejohnson@gmail.com"

                },
                new Staff
                {
                    StaffId = 2,
                    Name = "Bob Smith",
                    Email = "bobsmith@gmail.com"
                }
            );
        }
    }
}
