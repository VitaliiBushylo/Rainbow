using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Violet : Controller
    {
        // GET: Violet
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Violet ";
            return View();
        }
    }
}