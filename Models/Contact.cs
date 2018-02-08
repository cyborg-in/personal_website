using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace PersonalWebsite.Models
{
    public class Contact 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(125, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "An email address is required.  Sorry :-(.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}