using Microsoft.AspNet.Identity.EntityFramework;

namespace Pairme.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public int GenderID { get; set; }
        public int MatchGenderID { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }
        public int ZipCode { get; set; }
        public string ImageLink { get; set; }
        public string Summary { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}