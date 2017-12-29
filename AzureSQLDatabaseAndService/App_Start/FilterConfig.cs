using System.Web;
using System.Web.Mvc;

namespace AzureSQLDatabaseAndService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); // Added Comment#1
        }
    }
}
