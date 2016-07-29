using System.Web;
using System.Web.Mvc;

namespace comp2007_s2016_asgn_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
