using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MayewoPortfolio.Models;

namespace MayewoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        MyPortfolioEntities myPortfolioEntities = new MyPortfolioEntities();

        public ActionResult Index()
        {   var values = myPortfolioEntities.Projects.ToList();
            return View(values);
        }

        public void GetCategoryNames()
        {
            List<SelectListItem> values = (from i in myPortfolioEntities.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.Name,
                                               Value = i.CategoryId.ToString()
                                           }
                                    ).ToList();
            ViewBag.values = values;
        }
        [HttpGet]
        public ActionResult CreateNewProject()
        {
            GetCategoryNames();
            return View();
        }
        [HttpPost]
        public ActionResult CreateNewProject(Project project)
        {
            //var category = myPortfolioEntities.Categories.Where(c => c.CategoryId == project.CategoryId).FirstOrDefault();
            //project.Category = category;
            myPortfolioEntities.Projects.Add(project);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("CreateNewProject");
        }

        public ActionResult RemoveProject(int id)
        {
            var removeproject = myPortfolioEntities.Projects.Find(id);
            myPortfolioEntities.Projects.Remove(removeproject);
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            GetCategoryNames();
            var value = myPortfolioEntities.Projects.Find(id);
            return View(value);
        }
        
        [HttpPost]
        public ActionResult UpdateProject(Project project)
        {
            var value = myPortfolioEntities.Projects.Find(project.ProjectId);
            value.Title = project.Title;
            value.Description = project.Description;
            //var categoryname = myPortfolioEntities.Categories.Where(c => c.CategoryId == project.CategoryId).FirstOrDefault();
            //project.Category = categoryname;
            value.CategoryId = project.CategoryId;
            value.ImageUrl = project.ImageUrl;
            value.ProjectUrl = project.ProjectUrl;
            myPortfolioEntities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}