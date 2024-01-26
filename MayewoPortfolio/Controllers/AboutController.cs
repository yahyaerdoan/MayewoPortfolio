using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.Aboutes.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewAbout(Aboute aboute)
        {
            myPortfolioEntities.Aboutes.Add(aboute);
            myPortfolioEntities.SaveChanges();
            return View();
        }
    }
}