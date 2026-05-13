using System.ComponentModel.DataAnnotations;

namespace RegistrationValidationSystem.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Username must be between 3 and 20 characters")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [StringLength(15, MinimumLength = 6,
            ErrorMessage = "Password must be between 6 and 15 characters")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password is required")]
        [PasswordMatch("Password",
            ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}