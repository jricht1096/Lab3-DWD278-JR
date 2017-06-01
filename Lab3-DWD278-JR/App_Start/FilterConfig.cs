using System.Web;
using System.Web.Mvc;

namespace Lab3_DWD278_JR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
