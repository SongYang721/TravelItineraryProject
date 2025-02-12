using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;

namespace TravelItineraryProject.Configurations.Entities
{
    public class ItinerarySeed : IEntityTypeConfiguration<Itinerary>
    {
        public void Configure(EntityTypeBuilder<Itinerary> builder)
        {
            builder.HasData(
                new Itinerary
                {
                    ItineraryId = 1,
                    Price = 963,
                    Duration = 7,
                    Title = "Japan",
                    PromotionAvailable = false,
                    TypeofTrip = "Leisure",
                    StaffId = 2,
                    AvailableDateRanges = "14-16 February, 16-18 February",
                    Description = "Experience the best of Japan at a leisurely pace, blending serene natural beauty, cultural exploration, and indulgent relaxation. Perfect for those looking to unwind and immerse themselves in the tranquil charm of Japan",
                    ImageUrl = "Images/JapanItinerary.jpg"
                },
                new Itinerary
                {
                    ItineraryId = 2,
                    Price = 873,
                    Duration = 6,
                    Title = "Taiwan",
                    PromotionAvailable = true,
                    TypeofTrip = "Historical",
                    StaffId = 1,
                    AvailableDateRanges = "14-16 February, 16-18 February",
                    Description = "Discover the rich history and culture of Taiwan, from ancient temples to bustling night markets. This itinerary is perfect for history buffs and foodies alike, offering a taste of Taiwan's diverse heritage and culinary delights." ,
                    ImageUrl = "Images/Taiwan.jpg"

                }
            );
        }
    }
}
