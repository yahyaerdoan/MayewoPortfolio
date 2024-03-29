﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();
        public ActionResult Index()
        {
            var values = myPortfolioEntities.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateNewCategory()
        {         
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewCategory(Category category)
        {
            myPortfolioEntities.Categories.Add(category);
            myPortfolioEntities.SaveChanges();
            return View();
        }

        public ActionResult RemoveCategory(int id)
        {
            var removecategory = myPortfolioEntities.Categories.Find(id);
            myPortfolioEntities.Categories.Remove(removecategory);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory (int id)
        {
            var value = myPortfolioEntities.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var value = myPortfolioEntities.Categories.Find(category.CategoryId);
            value.Name = category.Name;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}