using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Grey : Controller
    {
        // GET: Grey
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Grey ";
            return View();
        }
    }
}