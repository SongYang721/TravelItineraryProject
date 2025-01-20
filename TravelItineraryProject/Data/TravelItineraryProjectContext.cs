using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelItineraryProject.Configurations.Entities;
using TravelItineraryProject.Data;

namespace TravelItineraryProject.Data
{
    public class TravelItineraryProjectContext(DbContextOptions<TravelItineraryProjectContext> options) : IdentityDbContext<TravelItineraryProjectUser>(options)
    {
        public DbSet<TravelItineraryProject.Domain.Payment> Make { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Review> Model { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Staff> Vehicle { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Itinerary> Colour { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Customer> Customer { get; set; } = default!;

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
        }
    }
}
