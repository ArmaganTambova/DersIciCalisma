using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MerhabaMVC.Models
{
    public class Kategori
    {
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılamaz")]
        [StringLength(maximumLength: 70, MinimumLength = 3, ErrorMessage = "Metin Uzunluğu 3 İle 70 Arasında Olmak Zorundadır")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}