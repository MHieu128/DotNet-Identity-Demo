using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
