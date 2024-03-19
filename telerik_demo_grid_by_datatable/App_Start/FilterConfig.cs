using System.Web;
using System.Web.Mvc;

namespace telerik_demo_grid_by_datatable
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
