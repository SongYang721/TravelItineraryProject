namespace TravelItineraryProject.Domain
{
    public class Booking : BaseDomainMode
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
