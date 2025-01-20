using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;

namespace TravelItineraryProject.Configurations.Entities
{
    public class PaymentSeed : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                new Payment
                {
                    PaymentId = 1,
                    NameOnCard = "John Doe",
                    CardNumber = "1234567812345678",
                    ExpiryDateOfCard = "12-25",
                    SecurityCode = "123",
                    PaymentStatus = true,
                    BookingId = 1,
                },
                new Payment
                {
                    PaymentId = 2,
                    NameOnCard = "Jane Smith",
                    CardNumber = "2345678923456789",
                    ExpiryDateOfCard = "11-24",
                    SecurityCode = "456",
                    PaymentStatus = false,
                    BookingId = 2,
                }
            );
        }
    }
}
