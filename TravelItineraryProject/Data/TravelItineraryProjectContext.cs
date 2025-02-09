using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelItineraryProject.Configurations.Entities;
using TravelItineraryProject.Data;

namespace TravelItineraryProject.Data
{
    public class TravelItineraryProjectContext(DbContextOptions<TravelItineraryProjectContext> options) : IdentityDbContext<TravelItineraryProjectUser>(options)
    {
        public DbSet<TravelItineraryProject.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Review> Review { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.ItineraryRequest> ItineraryRequest { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.SupportRequest> SupportRequest { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookinigSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new ItinerarySeed());
            builder.ApplyConfiguration(new PaymentSeed());
            builder.ApplyConfiguration(new ReviewSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new ItineraryRequestSeed());
        }
    }
}