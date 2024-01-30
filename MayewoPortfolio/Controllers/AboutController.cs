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

        public ActionResult UpdateAbout(int id)
        {
            var updateabout = myPortfolioEntities.Aboutes.Find(id);
            return View("UpdateAbout", updateabout);
        }

        public ActionResult UpdateAbout(Aboute aboute)
        {
            var updateaboute = myPortfolioEntities.Aboutes.Find(aboute.AboutId);
            updateaboute.Title = aboute.Title;
            updateaboute.Header = aboute.Header;
            updateaboute.Description = aboute.Description;
            updateaboute.ImageUrl = aboute.ImageUrl;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}