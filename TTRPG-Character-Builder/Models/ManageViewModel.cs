using System.ComponentModel.DataAnnotations;

namespace TTRPG_Character_Builder.Models
{
    public class ManageViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Add other properties as needed for profile management
    }

}
