using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace error_handle.Controllers
{
    public class NotFoundController : Controller
    {
        // GET: NotFound
        public ActionResult Index(string aspxerrorpath)
        {
            ViewBag.path = aspxerrorpath.Substring(1);
            
            return View();
        }
    }
}