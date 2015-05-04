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
        public string State { get; set; }
        public string City { get; set; }
        public int Height { get; set; }
        public string ImageLink { get; set; }
        public string Summary { get; set; }
        public int LookingForID { get; set; }
        public int RelationshipStatusID { get; set; }
        public int EthnicityID { get; set; }
        public int BodyTypeID { get; set; }
        public int ProfessionID { get; set; }
        public int EducationID { get; set; }
        public int ReligionID { get; set; }
        public int ChildrenID { get; set; }
        public int SmokesID { get; set; }
        public int DrinksID { get; set; }
        public int DrugsID { get; set; }
        public string LookingForSummary { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}