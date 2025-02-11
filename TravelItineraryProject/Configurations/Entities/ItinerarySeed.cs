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
                    ImageUrl = "https://www.google.com/imgres?q=photo%20of%20leisure%20japan&imgurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fwp-content%2Fuploads%2F2024%2F10%2FLeisure-Japan.jpg&imgrefurl=https%3A%2F%2Fwww.travelandtourworld.com%2Fnews%2Farticle%2Fleisure-japan-2024-to-showcase-in-tokyo-highlighting-innovations-in-theme-parks-and-sustainable-travel-from-october-16-18%2F&docid=oDDXWdoS4OBMmM&tbnid=-EKiPmzqiZi-DM&vet=12ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA..i&w=830&h=646&hcb=2&ved=2ahUKEwjUyr-D57iLAxVgS2cHHTb9HGsQM3oECH8QAA"

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
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fneocha.com%2Fmagazine%2Ftaiwan-then-now%2F&psig=AOvVaw09-bgY1IEvtpAp6qmoelo-&ust=1739266532110000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCMju7PHmuIsDFQAAAAAdAAAAABAE"

                }
            );
        }
    }
}
