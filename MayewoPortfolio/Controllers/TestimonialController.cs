using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewTestimonial(Testimonial testimonial)
        {
            myPortfolioEntities.Testimonials.Add(testimonial);
            myPortfolioEntities.SaveChanges();
            return View();
        }

        public ActionResult RemoveTestimonial(int id)
        {
            var removeteestimonial = myPortfolioEntities.Testimonials.Find(id);
            myPortfolioEntities.Testimonials.Remove(removeteestimonial);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = myPortfolioEntities.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = myPortfolioEntities.Testimonials.Find(testimonial.TestimonialId);
            value.NameSurname = testimonial.NameSurname;
            value.Description = testimonial.Description;
            value.ImageUrl = testimonial.ImageUrl;
            value.Statu = testimonial.Statu;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}