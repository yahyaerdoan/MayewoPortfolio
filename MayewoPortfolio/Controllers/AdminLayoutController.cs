using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
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