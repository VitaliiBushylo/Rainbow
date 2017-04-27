using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rainbow.Controllers
{
    public class Red : Controller
    {
        // GET: Red
        public ActionResult GetColorfullPage()
        {
            Session["Path"] += ">> Red ";
            return View();
        }
    }
}