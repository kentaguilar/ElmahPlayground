using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            throw new Exception("I am an exception");

            return Json(new
            {
                Status = "Completed"
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
