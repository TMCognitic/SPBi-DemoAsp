using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DemoAsp.FullMvc.Infrastructure.Attributes
{
    public class AuthorizeAreaAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            RouteData route = httpContext.Request.RequestContext.RouteData;

            String area = route.DataTokens["area"]?.ToString();


            if(area != null)
            {
                if(area == "Admin")
                {
                    return SessionManager.IsAdmin;
                }
                // Other Area
            }

            return true;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if(SessionManager.User != null)
            {
                filterContext.Result = new HttpStatusCodeResult(System.Net.HttpStatusCode.Forbidden);
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }

    }
}