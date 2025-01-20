using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;

namespace TravelItineraryProject.Configurations.Entities
{
    public class ReviewSeed : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    ReviewId = 1,
                    Rating = 5,
                    ReviewDate = new DateTime(2025, 1, 15),
                    Comment = "Excellent experience!",
                    ApprovedByStaff = true,
                    ItineraryId = 1,  // Assuming you have an Itinerary with ID 1
                    UserId = 1,       // Assuming you have a User with ID 1
                    StaffId = 1,
                },
                new Review
                {
                    ReviewId = 2,
                    Rating = 4,
                    ReviewDate = new DateTime(2025, 1, 18),
                    Comment = "Great service, but could improve the food quality.",
                    ApprovedByStaff = false,
                    ItineraryId = 2,  // Assuming you have an Itinerary with ID 2
                    UserId = 2,       // Assuming you have a User with ID 2
                    StaffId = 2
                }
            );
        }
    }
}
