using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Udvikling_til_mathmaniac.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
