using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TravelItineraryProject.Configurations.Entities;
using TravelItineraryProject.Data;

namespace TravelItineraryProject.Data
{
    public class TravelItineraryProjectContext(DbContextOptions<TravelItineraryProjectContext> options) : IdentityDbContext<TravelItineraryProjectUser>(options)
    {
        public DbSet<TravelItineraryProject.Domain.Make> Make { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Model> Model { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<TravelItineraryProject.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
        }
    }
}
