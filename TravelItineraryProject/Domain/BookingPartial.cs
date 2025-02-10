using System.ComponentModel.DataAnnotations.Schema;

namespace TravelItineraryProject.Domain
{
    public partial class Booking
    {
        [NotMapped]
        public string PaymentDisplayStatus { get; set; } = string.Empty;
    }
}
