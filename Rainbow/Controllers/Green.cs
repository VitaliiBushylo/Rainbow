using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Green : Controller
    {
        // GET: Green
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Green ";
            return View();
        }
    }
}