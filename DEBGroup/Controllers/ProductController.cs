using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DEBGroup.Controllers
{
    public class ProductController : Controller
    {
        EF.EAL39_DBEntities db = new EF.EAL39_DBEntities();
        // GET: Product
        public ActionResult Index(int id, int id2)
        {
            var m = new Models.Product.Index();

                // select * from sector where sectorid = 1
                m.DisplayName = db.Category.FirstOrDefault(p => p.CategoryID == id).CategoryName;

                // select distinct CategoryName, s.CategoryID from SCPconnection s, Category g where s.SectorID = 1 and s.CategoryID = g.CategoryID
                var allProductID = db.SCPconnection.Where(p => p.CategoryID == id2 && p.SectorID == id).Select(p => p.ProductID).Distinct();
                foreach (var ProductID in allProductID)
                {
                    var mc = new Models.Product.ModelProduct();
                    var c = db.Product.FirstOrDefault(p => p.ProductID == ProductID);

                    mc.ProductName= c.ProductName;
                    m.AllProducts.Add(mc);
                }
            return View(m);
        }


        public ActionResult Edit(int id3)
        {
            EF.Product product = db.Product.Find(id3);
            if (product == null)
            {
                return HttpNotFound();
            }
            
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit (EF.Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var product = db.Product.FirstOrDefault(p => p.ProductID == id);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var product = db.Product.FirstOrDefault(p => p.ProductID == id);
            var scp = db.SCPconnection.FirstOrDefault(s => s.ProductID == id);
            db.SCPconnection.Remove(scp);
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}