using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Site_One.newUser
{
    public class newUser
    {
        [Required]
        [StringLength(32, ErrorMessage = "Please enter a valid username.")]
        public string Username;

        [Required]
        [EmailAddress]
        public string Email;
    }
}