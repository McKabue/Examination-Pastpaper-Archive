using System.Web;
using System.Web.Mvc;

namespace Examination_Pastpaper_Archive
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
