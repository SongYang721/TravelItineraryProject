using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using TravelItineraryProject.Domain;


namespace TravelItineraryProject.Configurations.Entities
{
    public class SupportRequestSeed : IEntityTypeConfiguration<SupportRequest>
    {
        public void Configure(EntityTypeBuilder<SupportRequest> builder)
        {
            builder.HasData(
                new SupportRequest
                {
                    SupportRequestId = 1,
                    Assisted = false,
                    Comments = "My booking was denied even though payment went through",
                    CustomerId = 2,
                    TypeofSupport = "Payment Issues"
                },
                new SupportRequest
                {
                    SupportRequestId = 2,
                    Assisted = false,
                    Comments = "I would like to cancel my booking as i can't make it anymore on that date.",
                    CustomerId = 1,
                    TypeofSupport = "Cancel of Booking"
                }
            );

        }
    }
}
