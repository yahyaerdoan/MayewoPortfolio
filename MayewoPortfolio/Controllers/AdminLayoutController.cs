using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayewoPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult _Layout()
        {
            return View();
        }

        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        } 
        public PartialViewResult _SideBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }

    }
}