using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StorageFinalProject.Models;

namespace StorageFinalProject.Controllers
{
    public class ShopOperatorController : Controller
    {

        private FinalProjectEntities db = new FinalProjectEntities();

        // GET: /ShopOperator/

        public ActionResult ShowMenu()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult EmptyForm()
        {
            return View();
        }

        // mokled aq ra kodic weria shecdomitaa, names chawers kategoriis da producttypes da a.sh. user, xoda 
        //chven unda shevamowmot shesabamis cxrilshi aseti names mqone kategoria tu arsebobs, davitriot id, mere producttype da a.sh.
        //coll[0] daitrevs menule indeqsze mdgom key-s romelic aris Category. chven gadmovedit EmptyForm-idan.
        //exla aq vamowmeb monacemebs sworad sheiyvana tu ara ro mere qvemota ori veli gamovitano readonly rejimshi.
        //tu sworad gamoitana Viewbags iset monacemebs gavatan ro mere Checkinfo view-shi mivxvde ro sworad sheiyvana da davxato prosta ro sagol shen sworad 
        //sheiyvaneo. tu arasworad mashin checkinfoshi prosta cariels daxatav. EmptyForms ver vidzaxeb aqedan tore idealuri qienboda.
        public ActionResult CheckInfo(FormCollection coll)
        {
            /*WarehouseProduct product = new WarehouseProduct();
            int categoryID = Convert.ToInt32(coll[0]);
            int productTypeID = Convert.ToInt32(coll[1]);
            int warehouseID = Convert.ToInt32(coll[2]);

            foreach (WarehouseProduct prod in db.WarehouseProducts)
            {
                if (prod.WarehouseID == warehouseID && prod.CategoryID == categoryID && prod.ProductTypeID == productTypeID)
                {

                }
            }*/
            return View();
        }
    }
}
