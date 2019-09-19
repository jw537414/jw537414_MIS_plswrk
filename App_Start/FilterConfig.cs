using System.Web;
using System.Web.Mvc;

namespace jw537414_MIS_plswrk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
