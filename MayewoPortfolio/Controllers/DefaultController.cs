using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    
    public class DefaultController : Controller
    {
        // GET: Default
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

       public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavBarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = myPortfolioEntities.Futures.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values = myPortfolioEntities.Aboutes.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = myPortfolioEntities.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = myPortfolioEntities.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult ProjectPartial()
        {
            var values = myPortfolioEntities.Projects.ToList();
            return PartialView(values);
        }

        public PartialViewResult SocialMediaPartial()
        {
            var values = myPortfolioEntities.SocialMedias.ToList();
            return PartialView(values);
        }
    }
}