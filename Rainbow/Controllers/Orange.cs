using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Orange : Controller
    {
        // GET: Orange
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Orange ";
            return View();
        }
    }
}