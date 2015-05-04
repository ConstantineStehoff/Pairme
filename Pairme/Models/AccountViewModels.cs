using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;


namespace Pairme.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModelStep1
    {
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }
        
        [Required]
        [Display(Name = "Gender")]
        public int GenderID { get; set; }

        [Required]
        [Display(Name = "Match Gender")]
        public int MatchGenderID { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryID { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }

    public class RegisterViewModelStep2
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModelStep3
    {
        [Display(Name = "Upload Picture")]
        public HttpPostedFileBase PictureFile { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Required]
        [Display(Name = "I accept User Agreement")]
        public bool TermsOfService { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public int GenderID { get; set; }

        [Required]
        [Display(Name = "Match Gender")]
        public int MatchGenderID { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm email")]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Country")]
        public int CountryID {get; set;}

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        [Display(Name = "Height")]
        public int Height { get; set; }

        [Display(Name = "Image Link")]
        public string ImageLink { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Looking For")]
        public int LookingForID { get; set; }

        [Display(Name = "Relationship Status")]
        public int RelationshipStatusID { get; set; }

        [Display(Name = "Ethnicity")]
        public int EthnicityID { get; set; }

        [Display(Name = "Body Type")]
        public int BodyTypeID { get; set; }

        [Display(Name = "Profession")]
        public int ProfessionID { get; set; }

        [Display(Name = "Education")]
        public int EducationID { get; set; }

        [Display(Name = "Religion")]
        public int ReligionID { get; set; }

        [Display(Name = "Children")]
        public int ChildrenID { get; set; }

        [Display(Name = "Smokes")]
        public int SmokesID { get; set; }

        [Display(Name = "Drinks")]
        public int DrinksID { get; set; }

        [Display(Name = "Drugs")]
        public int DrugsID { get; set; }

        [Display(Name = "What I am Looking For")]
        public string LookingForSummary { get; set; }
    }

    // Model for displaying data in the profile page 
    // (Maybe totatlly wrong approach)
    public class DisplayProfileModel
    {
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }

        [Display(Name = "Height")]
        public int Height { get; set; }

        [Display(Name = "Image Link")]
        public string ImageLink { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Looking For")]
        public string LookingFor { get; set; }

        [Display(Name = "Relationship Status")]
        public string RelationshipStatus { get; set; }

        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [Display(Name = "Body Type")]
        public string BodyType { get; set; }

        [Display(Name = "Profession")]
        public string Profession { get; set; }

        [Display(Name = "Education")]
        public string Education { get; set; }

        [Display(Name = "Religion")]
        public string Religion { get; set; }

        [Display(Name = "Children")]
        public string Children { get; set; }

        [Display(Name = "Smokes")]
        public string Smokes { get; set; }

        [Display(Name = "Drinks")]
        public string Drinks { get; set; }

        [Display(Name = "Drugs")]
        public string Drugs { get; set; }

        [Display(Name = "What I am Looking For")]
        public string LookingForSummary { get; set; } 
    }

    public class Gender
    {
        public int ID { get; set; }
        public string GenderName { get; set; }
    }

    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
    }

    public class LookingFor
    {
        public int ID { get; set; }
        public string LookingForName { get; set; }
    }

    public class RelationshipStatus
    {
        public int ID { get; set; }
        public string RelationshipStatusName { get; set; }
    }

    public class Ethnicity
    {
        public int ID { get; set; }
        public string EthnicityName { get; set; }
    }

    public class BodyType
    {
        public int ID { get; set; }
        public string BodyTypeName { get; set; }
    }

    public class Profession
    {
        public int ID { get; set; }
        public string ProfessionName { get; set; }
    }

    public class Education
    {
        public int ID { get; set; }
        public string EducationLevel { get; set; }
    }

    public class Religion
    {
        public int ID { get; set; }
        public string ReligionName { get; set; }
    }

    public class Children
    {
        public int ID { get; set; }
        public string ChildrenName { get; set; }
    }

    public class Smokes
    {
        public int ID { get; set; }
        public string SmokesName { get; set; }
    }

    public class Drinks
    {
        public int ID { get; set; }
        public string DrinksName { get; set; }
    }

    public class Drugs
    {
        public int ID { get; set; }
        public string DrugsName { get; set; }
    }
}
