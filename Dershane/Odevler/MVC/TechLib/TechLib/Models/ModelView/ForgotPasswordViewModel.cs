using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechLib.Models.ModelView
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Required Field")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Email must be between 5 and 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EMail { get; set; }
    }
}