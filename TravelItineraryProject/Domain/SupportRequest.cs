namespace TravelItineraryProject.Domain
{
    public class SupportRequest : BaseDomainModel
    {
        public int SupportRequestId { get; set; } //PK

        public bool Assisted { get; set; }
        public string? Comments { get; set; }

        public string? TypeofSupport { get; set; }

        public int CustomerId { get; set; } // FK (User making the support request)
        public Customer? Customer { get; set; } // Navigation Property

        public int? StaffId { get; set; }    // FK
        public Staff? Staff { get; set; }  // Nav
    }
}