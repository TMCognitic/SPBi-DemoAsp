using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAsp.FullMvc.Models.Forms
{
    public class LoginForm
    {
        [Required]
        [EmailAddress]
        [DisplayName("Email : ")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [DisplayName("Mot de passe : ")]
        public string Passwd { get; set; }
    }
}