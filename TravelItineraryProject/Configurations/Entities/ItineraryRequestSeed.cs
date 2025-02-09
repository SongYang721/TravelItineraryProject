using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;


namespace TravelItineraryProject.Configurations.Entities
{
    public class ItineraryRequestSeed : IEntityTypeConfiguration<ItineraryRequest>
    {
        public void Configure(EntityTypeBuilder<ItineraryRequest> builder)
        {
            builder.HasData(
                new ItineraryRequest
                {
                    ItineraryRequestId = 1,
                    RequestApproval = false,
                    //RequestTravelMonthYear = new DateTime(2024, 1, 3),
                    Destination = "Paris, France",
                    TypeOfTrip = "History",
                    NumberOfRequests = 1,
                    CustomerId = 1,
                    StaffId = 1

                },
                new ItineraryRequest
                {
                    ItineraryRequestId = 2,
                    RequestApproval = false,
                    //RequestTravelMonthYear = new DateTime(2024, 1, 3),
                    Destination = "Tokyo, Japan",
                    TypeOfTrip = "Vacation",
                    NumberOfRequests = 20,
                    CustomerId = 2,
                    StaffId = 2

                }
            );

        }
    }
}
