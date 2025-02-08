using Microsoft.AspNetCore.Identity;

namespace TravelItineraryProject.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class TravelItineraryProjectUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? CustomerId { get; set; }
        public int? StaffId { get; set; }
    }
}
