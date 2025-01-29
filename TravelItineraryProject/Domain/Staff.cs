using System.Collections.Generic;

namespace TravelItineraryProject.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffId { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public List<Itinerary>? Itineraries { get; set; } // = new List<Itinerary>();
        public List<Review>? Reviews { get; set; } // = new List<Review>();
        public List<Booking>? Bookings { get; set; } // = new List<Booking>();
    }
}
