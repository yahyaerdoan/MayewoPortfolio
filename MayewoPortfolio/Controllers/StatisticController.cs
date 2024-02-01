using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCout = myPortfolioEntities.Projects.Count();
            //Aggregate --> Sum Count Avg Min Max
            ViewBag.categoryCount = myPortfolioEntities.Categories.Count();
            ViewBag.projectCount = myPortfolioEntities.Projects.Count();
            ViewBag.messageCount = myPortfolioEntities.Communications.Count();
            ViewBag.flutterProjectCount = myPortfolioEntities.Projects.Where(x => x.CategoryId == 1).Count();
            ViewBag.isNotReadMessageCount = myPortfolioEntities.Communications.Where(x => x.IsRead == false).Count();
            ViewBag.lastProjectName = myPortfolioEntities.LastProjectName().FirstOrDefault();
            ViewBag.lastProjectName = myPortfolioEntities.LastProjectName().FirstOrDefault();
            return View();
        }
    }
}