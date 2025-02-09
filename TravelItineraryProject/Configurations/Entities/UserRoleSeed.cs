using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace TravelItineraryProject.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",// this is the admin role
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518bc",//this is the staff role
                UserId = "10e93995-24eb-48b5-805b-824adeb6fb96"
            },
            new IdentityUserRole<string>
            {
                RoleId = "cd2bcf0c-20db-474f-8407-5a6b159518bc",// this is the staff role
                UserId = "f272bf94-a1ab-451a-b55a-0e68638d6bb4"
            },
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",// this is the customer role
                UserId = "4fd66d43-0660-4dc0-a96e-f83b593e4175"
            },
            new IdentityUserRole<string>
            {
                RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",// this is the customer role
                UserId = "f8b82324-d7ce-4578-9b88-2b6d693b72de"
            }
            );
        }
    }
}