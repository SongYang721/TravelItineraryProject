namespace TravelItineraryProject.Domain
{
    public class Payment : BaseDomainModel
    {
        public int PaymentId { get; set; } // PK
        public string? NameOnCard { get; set; }
        public string? CardNumber { get; set; }
        public string? ExpiryDateOfCard { get; set; }
        public string? SecurityCode { get; set; }
        public bool? PaymentStatus { get; set; }
    }
}
