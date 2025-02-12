    namespace TravelItineraryProject.Domain
    {
        public class ItineraryRequest
        {
            public int ItineraryRequestId { get; set; } //PK

            public bool RequestApproval { get; set; }
            //public DateTime RequestTravelMonthYear { get; set; }

            public string? Destination { get; set; }

            public string? TypeOfTrip { get; set; }

            public int? NumberOfRequests { get; set; }

            public int CustomerId { get; set; } // FK (User making the request for certain itinerary)
            public Customer? Customer { get; set; } // Navigation Property

            public int? StaffId { get; set; }    // FK
            public Staff? Staff { get; set; }  // Nav
        }
    }