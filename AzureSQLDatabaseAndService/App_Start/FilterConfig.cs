using System.Web;
using System.Web.Mvc;

namespace AzureSQLDatabaseAndService
{
    public class FilterConfig
    {
        /// <summary>
        /// The method is used to register filters
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); // Added Comment#1 // Added Comment#2
        }
    }
}
