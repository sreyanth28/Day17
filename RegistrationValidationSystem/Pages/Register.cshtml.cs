using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistrationValidationSystem.Models;

namespace RegistrationValidationSystem.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserRegistration User { get; set; }
            = new UserRegistration();

        public string SuccessMessage { get; set; }
            = string.Empty;

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                SuccessMessage = "Registration Successful!";
            }
        }
    }
}