namespace TravelItineraryProject.Domain
{
    public class Booking : BaseDomainModel
    {
        public int BookingId { get; set; }

        public DateOnly BookingDate { get; set; }


        public int UserId { get; set; } //Fk
        public virtual Customer? User { get; set; } // Nav

        public int ItineraryId { get; set; } // Fk
        public virtual Itinerary? Itinerary { get; set; } // Nav

        public int PaymentId { get; set; } // Fk
        public virtual Payment? Payment { get; set; } // Nav


        public int StaffId { get; set; } // Fk
        public virtual Staff? Staff { get; set; } // Nav
    }
}
