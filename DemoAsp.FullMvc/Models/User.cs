using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAsp.FullMvc.Models
{
    [Flags]
    public enum RoleUser
    {
        User = 1,
        Admin = 2
    }

    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public RoleUser Role { get; set; }
    }
}