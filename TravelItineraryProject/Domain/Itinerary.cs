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

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>(); // Nav

        // New fields for booking date range
        //[Required(ErrorMessage = "FromDate is required.")]
        //public DateOnly FromDate { get; set; }

        // Store available date ranges as a single string, separated by commas
        public string AvailableDateRanges { get; set; }  // e.g., "14-16 February, 16-18 February"

        // Method to get date ranges as a list
        public List<string> GetAvailableDateRanges()
        {
            return AvailableDateRanges?.Split(',').ToList() ?? new List<string>();
        }

        //[Required(ErrorMessage = "ToDate is required.")]
        //public DateOnly ToDate { get; set; }
    }
}
