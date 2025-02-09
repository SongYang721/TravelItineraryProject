namespace TravelItineraryProject.Domain
{
    public class Customer : BaseDomainModel
    {
        public int CustomerId { get; set; } //PK
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public ICollection<Booking>? Bookings { get; set; } //  = new List<Booking>();
        public ICollection<Review>? Reviews { get; set; } // = new List<Review>();
        public ICollection<SupportRequest>? SupportRequests { get; set; }
        public ICollection<ItineraryRequest>? ItineraryRequests { get; set; }
    }
}
