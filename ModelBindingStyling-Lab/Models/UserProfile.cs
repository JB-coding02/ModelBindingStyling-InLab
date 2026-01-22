using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelBindingStyling_Lab.Models
{
    /// <summary>
    /// Individual user profile information
    /// </summary>
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        /// <summary>
        /// First and last legal name of the user
        /// </summary>
        [Display(Name = "Full Name")]
        public required string FullName { get; set; }

        /// <summary>
        /// User date of birth
        /// </summary>
        [Display(Name = "Date of birth")]
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Contact email
        /// </summary>
        [Display(Name = "Email Address")]
        public required string Email { get; set; }

        /// <summary>
        /// Contact phone number
        /// </summary>
        [Display(Name = "Phone Number")]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Profile image of the user
        /// </summary>
        [Display(Name = "Image URL")]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// The users GitHub profile URL
        /// </summary>
        [Display(Name = "GitHub URL")]
        public required string GitHubUrl { get; set; }

        /// <summary>
        /// List of languages the user is skilled in. Will be an empty
        /// list if there are 0
        /// </summary>
        [Display(Name = "Skilled Languages")]
        public List<string> SkilledLanguages { get; set; } = [];
    }
}
