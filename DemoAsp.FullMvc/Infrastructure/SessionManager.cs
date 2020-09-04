using DemoAsp.FullMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAsp.FullMvc.Infrastructure
{
    public static class SessionManager
    {
        public static User User
        {
            get { return (User)HttpContext.Current.Session[nameof(User)]; }
            set { HttpContext.Current.Session[nameof(User)] = value; }
        }

        public static bool IsAdmin
        {
            get { return User?.Role.HasFlag(RoleUser.Admin) ?? false; }
        }

        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}