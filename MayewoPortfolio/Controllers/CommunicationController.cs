using MayewoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MayewoPortfolio.Controllers
{
    public class CommunicationController : Controller
    {
        // GET: Contact
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.Communications.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewCommunication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCommunication(Communication communication)
        {
            myPortfolioEntities.Communications.Add(communication);
            myPortfolioEntities.SaveChanges();
            return View();
        }
    }
}