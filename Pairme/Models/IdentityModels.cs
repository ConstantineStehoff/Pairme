using Microsoft.AspNet.Identity.EntityFramework;

namespace Pairme.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MatchGender { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}