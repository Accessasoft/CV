using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CanView.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<CanView.Models.FAQ> FAQs { get; set; }

        //public System.Data.Entity.DbSet<CanView.Models.Pricing> Pricings { get; set; }

        //public System.Data.Entity.DbSet<CanView.Models.SnackBar> SnackBars { get; set; }

        public System.Data.Entity.DbSet<CanView.Models.ContactUs> ContactUs { get; set; }
        public DbSet<TicketPricing> ticketPrices { get; set; }
        public DbSet<SbItem> snackBarItems { get; set; }
        public DbSet<SbItemSize> snackBarItemsSizes { get; set; }
        public DbSet<SbItemType> snackbarItemsTypes { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Nights> nights { get; set; }
        public DbSet<NightsOpen> nightsOpen { get; set; }
        public DbSet<NowPlaying> nowPlayings { get; set; }
        public DbSet<Rating> ratings { get; set; }
        public DbSet<Screen> screens { get; set; }
        public DbSet<Warnings> warings { get; set; }
        public DbSet<SbItem_Item_ItemSize> snackBarkItems_Items_Size { get; set; }
    }
}