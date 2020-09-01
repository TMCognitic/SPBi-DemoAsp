using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAsp.FullMvc.Models.Forms
{
    public class RegisterForm
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DisplayName("Nom : ")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Prénom : ")]
        public string FirstName { get; set; }
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