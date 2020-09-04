using DemoAsp.FullMvc.Infrastructure.Attributes;
using System.Web;
using System.Web.Mvc;

namespace DemoAsp.FullMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AuthorizeAreaAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
