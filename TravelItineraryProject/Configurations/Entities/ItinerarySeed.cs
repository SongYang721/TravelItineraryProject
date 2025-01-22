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
                    StaffId = 2
                },
                new Itinerary
                {
                    ItineraryId = 2,
                    Price = 873,
                    Duration = 6,
                    Title = "Taiwan",
                    PromotionAvailable = true,
                    TypeofTrip = "Historical",
                    StaffId = 1
                }
            );
        }
    }
}
