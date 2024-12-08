using TravelItineraryProject.Data;
using Microsoft.AspNetCore.Identity;

namespace TravelItineraryProject.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<TravelItineraryProjectUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<TravelItineraryProjectUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
