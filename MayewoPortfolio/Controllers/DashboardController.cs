using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        MyPortfolioEntities db = new MyPortfolioEntities();

        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.Categories.Count();
            ViewBag.projectCount = db.Projects.Count();
            ViewBag.messageCount = db.Communications.Count();
            return View();
        }
    }
}