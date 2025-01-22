using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelItineraryProject.Domain;


namespace TravelItineraryProject.Configurations.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    CustomerId = 1,
                    Password = "hashedPasswordUser1", // Ensure this is a hashed password in real scenarios
                    FirstName = "John",
                    LastName = "Doe",
                    EmailAddress = "johndoe@example.com",
                    RequestID = "REQ001",
                },
                new Customer
                {
                    CustomerId = 2,
                    Password = "hashedPasswordUser2", // Ensure this is a hashed password in real scenarios
                    FirstName = "Jane",
                    LastName = "Smith",
                    EmailAddress = "janesmith@example.com",
                    RequestID = "REQ002",
                }
            );

        }
    }
}
