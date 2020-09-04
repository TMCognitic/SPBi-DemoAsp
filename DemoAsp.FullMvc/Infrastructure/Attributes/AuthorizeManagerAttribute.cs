using DemoAsp.FullMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoAsp.FullMvc.Infrastructure.Attributes
{
    public class AuthorizeManagerAttribute : AuthorizeAttribute
    {
        private RoleUser? RoleAccess { get; }

        public AuthorizeManagerAttribute()
        {
            RoleAccess = null;
        }
        public AuthorizeManagerAttribute(RoleUser roleAccess)
        {
            RoleAccess = roleAccess;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if(SessionManager.User == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary()
                    {
                        { "action", "Login" },
                        { "controller", "Auth"}
                    }
                );
            }
            //else if (RoleAccess != null ? (bool)RoleAccess?.HasFlag(SessionManager.User.Role) : false)
            else if (!(RoleAccess?.HasFlag(SessionManager.User.Role) ?? true))
            {
                filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
        }
    }
}