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

        public ActionResult RemoveAbout(int id)
        {
            var removeabout = myPortfolioEntities.Aboutes.Find(id);
            myPortfolioEntities.Aboutes.Remove(removeabout);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = myPortfolioEntities.Aboutes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(Aboute aboute)
        {
            var value = myPortfolioEntities.Aboutes.Find(aboute.AboutId);
            value.Title = aboute.Title;
            value.Header = aboute.Header;
            value.Description = aboute.Description;
            value.ImageUrl = aboute.ImageUrl;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}