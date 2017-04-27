using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Blue : Controller
    {
        // GET: Blue
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Blue ";
            return View();
        }
    }
}