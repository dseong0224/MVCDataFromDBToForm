using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range( 100000, 999999, ErrorMessage = "Must enter valid Employee ID")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Must enter first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Must enter last name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Must enter email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email Address")]
        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress",ErrorMessage = "Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Password must be at least 10 characters")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare( "Password", ErrorMessage = "Password must match.")]
        public string ConfirmPassword { get; set; }
    }
}