using Microsoft.EntityFrameworkCore;

namespace TravelItineraryProject.Domain
{
    public class Booking : BaseDomainModel
    {
        public int BookingId { get; set; } //PK

        public bool? BookingStatus { get; set; }
        public DateOnly BookingDate { get; set; }
            
        public int? CustomerId { get; set; } //Fk
        public Customer? Customer { get; set; } // Nav
        public int ItineraryId { get; set; } // Fk
        public Itinerary? Itinerary { get; set; } // Nav
        public int PaymentId { get; set; } // Fk
        public Payment? Payment { get; set; } // Nav
        public int? StaffId { get; set; } // Fk
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Staff? Staff { get; set; } // Nav
    }
}
