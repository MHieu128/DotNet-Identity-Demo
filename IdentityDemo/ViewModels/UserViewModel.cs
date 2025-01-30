using System.ComponentModel.DataAnnotations;

namespace IdentityDemo.ViewModels
{
    public class UserViewModel
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
