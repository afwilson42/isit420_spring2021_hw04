using System.Web;
using System.Web.Mvc;

namespace isit420hw04JadeAndrew
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
