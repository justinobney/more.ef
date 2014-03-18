using System.Web;
using System.Web.Mvc;

namespace learn.more.ef.command_query
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
