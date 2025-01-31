using System.Collections.Generic;

namespace TravelItineraryProject.Domain
{
    public class Staff : BaseDomainModel
    {
        public int StaffId { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }

        public ICollection<Itinerary>? Itineraries { get; set; } // = new List<Itinerary>();
        public ICollection<Review>? Reviews { get; set; } // = new List<Review>();
        public ICollection<Booking>? Bookings { get; set; } // = new List<Booking>();
    }
}
