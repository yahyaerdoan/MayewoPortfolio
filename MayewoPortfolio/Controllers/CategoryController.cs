using System;
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
    }
}