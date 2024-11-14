using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechLib.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Required Field")]
        [Range(111111, 999999, ErrorMessage = "ID Must Be A 6-Digit Number")]
        public int ID { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required Field")]
        public string UserPassword { get; set; }
    }
}