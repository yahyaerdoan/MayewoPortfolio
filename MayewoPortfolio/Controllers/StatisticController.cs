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
            //Aggregate --> Sum Count Avg Min Max
            ViewBag.projectCount = myPortfolioEntities.Projects.Count();            
            ViewBag.categoryCount = myPortfolioEntities.Categories.Count();
            ViewBag.projectCount = myPortfolioEntities.Projects.Count();
            ViewBag.messageCount = myPortfolioEntities.Communications.Count();
            ViewBag.flutterProjectCount = myPortfolioEntities.Projects.Where(x => x.CategoryId == 1).Count();
            ViewBag.totalSrviceCount = myPortfolioEntities.Services.Count();
            ViewBag.ReadMessageCount = myPortfolioEntities.Communications.Where(x => x.IsRead == true).Count();
            ViewBag.isNotReadMessageCount = myPortfolioEntities.Communications.Where(x => x.IsRead == false).Count();
            ViewBag.lastProjectName = myPortfolioEntities.LastProjectName().FirstOrDefault();
            ViewBag.lastAspNetCoreMvcProject = myPortfolioEntities.LastAspNetCoreMvcProject().FirstOrDefault().Title;
            ViewBag.aspNetCoreMvcProjectCount = myPortfolioEntities.Projects.Where(x => x.CategoryId == 10).Count();
            var values = myPortfolioEntities.Projects.GroupBy(x => x.CategoryId).Select(x => new
            {
                Count = x.Count(),
                Key = x.Key,
            }).ToList();
            var value = values.Where(x => x.Count == values.Max(y => y.Count)).Select(z => z.Key).FirstOrDefault();
            var valueName = myPortfolioEntities.Categories.Where(x => x.CategoryId == value).FirstOrDefault();
            ViewBag.categoryWithTheMostProjects = valueName.Name;
            return View();
        }
    }
}