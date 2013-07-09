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


    }
}
