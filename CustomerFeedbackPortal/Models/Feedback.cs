using System.ComponentModel.DataAnnotations;

namespace CustomerFeedbackPortal.Models
{
    public class Feedback
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comments { get; set; } = string.Empty;
    }
}