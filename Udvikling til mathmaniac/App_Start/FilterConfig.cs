using System.Web;
using System.Web.Mvc;

namespace Udvikling_til_mathmaniac
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
