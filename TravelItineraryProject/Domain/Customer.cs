namespace TravelItineraryProject.Domain
{
    public class Customer : BaseDomainModel
    {
        public int UserId { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? RequestID { get; set; }
        public ICollection<Booking>? Bookings { get; set; } //  = new List<Booking>();
        public ICollection<Review>? Reviews { get; set; } // = new List<Review>();
    }
}
