using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

    [Serializable]
    public class RegisterViewModelStep1 : IStepViewModel
    {
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Match Gender")]
        public string MatchGender { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }

    [Serializable]
    public class RegisterViewModelStep2 : IStepViewModel
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

    [Serializable]
    public class WizardViewModel
    {
        public int CurrentStepIndex { get; set; }
        public IList<IStepViewModel> Steps { get; set; }

        public void Initialize()
        {
            Steps = typeof(IStepViewModel)
                    .Assembly
                    .GetTypes()
                    .Where(t => !t.IsAbstract && typeof(IStepViewModel).IsAssignableFrom(t))
                    .Select(t => (IStepViewModel)Activator.CreateInstance(t))
                    .ToList();
        }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Match Gender")]
        public string MatchGender { get; set; }

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
        public string Country {get; set;}

        [Required]
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}


//Model binder
public class StepViewModelBinder : DefaultModelBinder
{
    protected object CreateModel(System.Web.Mvc.ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
    {
        var stepTypeValue = bindingContext.ValueProvider.GetValue("StepType");
        var stepType = Type.GetType((string)stepTypeValue.ConvertTo(typeof(string)), true);
        var step = Activator.CreateInstance(stepType);
        bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(() => step, stepType);
        return step;
    }
}
