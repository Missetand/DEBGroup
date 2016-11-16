using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEBGroup.Controllers
{
    public class ProductController : Controller
    {
        EF.EAL39_DBEntities db = new EF.EAL39_DBEntities();
        // GET: Product
        public ActionResult Index()
        {
            
            return View(db.Product.ToList());
        }
        public ActionResult Details(int id)
        {
            var product = db.Product.FirstOrDefault(p => p.ProductID == id);
            
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            var product = db.Product.FirstOrDefault(p => p.ProductID == id);

            if (TryUpdateModel(product, "",
                new string[] { "ProductName", "Details" }))
                db.SaveChanges();
            return View(product);
        }


    }
}