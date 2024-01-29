using MayewoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayewoPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
           var values=  myPortfolioEntities.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewService(Service service)
        {
            myPortfolioEntities.Services.Add(service);
            myPortfolioEntities.SaveChanges();
            return View();
        }

        public ActionResult RemoveService(int id)
        {
            var removeservice = myPortfolioEntities.Services.Find(id);
            myPortfolioEntities.Services.Remove(removeservice);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}