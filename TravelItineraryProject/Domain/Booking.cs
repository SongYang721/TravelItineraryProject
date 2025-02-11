using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelItineraryProject.Domain
{
    public partial class  Booking : BaseDomainModel
    {
        public int BookingId { get; set; } //PK

        public bool BookingStatus { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string? SelectedDateRange { get; set; }

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
