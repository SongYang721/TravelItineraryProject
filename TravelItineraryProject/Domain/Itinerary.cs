using System.ComponentModel.DataAnnotations;

namespace TravelItineraryProject.Domain
{
    public class Itinerary : BaseDomainModel
    {
        public int ItineraryId { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal? Price { get; set; }
        public int? Duration { get; set; }
        public string? Title { get; set; }
        public bool PromotionAvailable { get; set; }
        public string? TypeofTrip { get; set; }
        public int StaffId { get; set; }    // FK
        public Staff Staff { get; set; }  // Nav
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>(); // Nav
    }
}
