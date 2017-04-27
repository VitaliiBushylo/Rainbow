using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Yellow : Controller
    {
        // GET: Yellow
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Yellow ";
            return View();
        }
    }
}