using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;


namespace TravelItineraryProject.Configurations.Entities
{
    public class BookinigSeed : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    BookingId = 1,
                    BookingStatus = false,
                    SelectedDateRange = "14-16 February",
                    CustomerId = 1,
                    ItineraryId = 1,
                    PaymentId = 1,
                    StaffId = 1
                },
                new Booking
                {
                    BookingId = 2,
                    BookingStatus = false,
                    SelectedDateRange = "16-18 February",
                    CustomerId = 2,
                    ItineraryId = 2,
                    PaymentId = 2,
                    StaffId = 2
                }
            );

        }
    }
}
