using StorageFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StorageFinalProject.Controllers
{
    public class StorageOperatorController : Controller
    {
        //
        // GET: /StorageOperator/

        private FinalProjectEntities db = new FinalProjectEntities();


        public ActionResult Category()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Create(Category category)
        {
            return View(new Category());
        }


        [HttpPost]
        public ActionResult AddCategory(HttpPostedFileBase name, HttpPostedFileBase description)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {

            }
            Category ct = new Category();
            ct.name = name.ToString();
            ct.description = description.ToString();
            db.Categories.Add(ct);
            db.SaveChanges();
            return View();
        }


    }
}
