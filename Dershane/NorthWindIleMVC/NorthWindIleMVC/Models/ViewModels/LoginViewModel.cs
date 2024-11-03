using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthWindIleMVC.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılamaz")]

        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        public string Password { get; set; }
    }
}