using System.Web;
using System.Web.Mvc;

namespace NguyenTranKimDung_2080600208_THWebB3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
