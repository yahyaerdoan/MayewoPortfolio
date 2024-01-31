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

        public ActionResult RemoveCommunicaton(int id)
        {
            var removecommunicaton = myPortfolioEntities.Communications.Find(id);
            myPortfolioEntities.Communications.Remove(removecommunicaton);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCommunication(int id)
        {
            var value = myPortfolioEntities.Communications.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCommunication(Communication communication)
        {
            var value = myPortfolioEntities.Communications.Find(communication.ContactId);
            value.NameSurname = communication.NameSurname;
            value.Email = communication.Email;
            value.CatgoryId = communication.CatgoryId;
            value.Message = communication.Message;
            value.SendDate = communication.SendDate;
            value.IsRead = communication.IsRead;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}