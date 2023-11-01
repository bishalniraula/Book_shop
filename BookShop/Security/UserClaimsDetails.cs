using BookShop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace BookShop.Security
{
    public class UserClaimsDetails : UserClaimsPrincipalFactory<BookShopUser, IdentityRole>
    {
        public UserClaimsDetails(UserManager<BookShopUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
           
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(BookShopUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("FullName", user.UserName));
            identity.AddClaim(new Claim("UserId", user.Id));
            return identity;
        }
    }
}
