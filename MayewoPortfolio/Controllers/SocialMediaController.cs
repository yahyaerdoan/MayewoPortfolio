using MayewoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayewoPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.SocialMedias.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewSocialMedia(SocialMedia socialMedia)
        {
            myPortfolioEntities.SocialMedias.Add(socialMedia);
            myPortfolioEntities.SaveChanges();
            return View();
        }

        public ActionResult RemoveSocialMedia(int id)
        {
            var removesocialmedia = myPortfolioEntities.SocialMedias.Find(id);
            myPortfolioEntities.SocialMedias.Remove(removesocialmedia);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = myPortfolioEntities.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = myPortfolioEntities.SocialMedias.Find(socialMedia.SocialMediaId);
            value.Title = socialMedia.Title;
            value.Url = socialMedia.Url;
            value.Icon = socialMedia.Icon;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}