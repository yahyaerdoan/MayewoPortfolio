﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;


namespace MayewoPortfolio.Controllers
{
    public class FutureController : Controller
    {
        // GET: Futures
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.Futures.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewFeature(Future feature)
        {
            myPortfolioEntities.Futures.Add(feature);
            myPortfolioEntities.SaveChanges();
            return View();
        }

        public ActionResult RemoveFeature(int id)
        {
            var removefeature = myPortfolioEntities.Futures.Find(id);
            myPortfolioEntities.Futures.Remove(removefeature);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateFuture(int id)
        {
            var value = myPortfolioEntities.Futures.Find(id);
            return View(value);
        }
        
        [HttpPost]
        public ActionResult UpdateFuture(Future future)
        {
            var value = myPortfolioEntities.Futures.Find(future.FutureId);
            value.NameSurname = future.NameSurname;
            value.Title = future.Title;
            value.Header = future.Header;
            value.Title = future.Title;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}  
