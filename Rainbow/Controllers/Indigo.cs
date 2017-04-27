using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Indigo : Controller
    {
        // GET: Indigo
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Indigo ";
            return View();
        }
    }
}