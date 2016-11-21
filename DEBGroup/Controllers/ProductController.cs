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
        public ActionResult Index(int id)
        {
            var m = new Models.Product.Index();
            
            //m.DisplayName = "Produkter";
            //var scp = db.SCPconnection.FirstOrDefault(s => s.CategoryID == id);
            //if (id == scp.ProductID)
                {

                foreach (var item in db.Product.OrderBy(p => p.ProductName))
                {
                    var mp = new Models.Product.ModelProduct();
                    mp.SectorName = item.ProductName;
                    mp.ProductID = item.ProductID;
                    mp.DetailsUrl = item.Details;
                    m.AllProducts.Add(mp);  
                    if (item.ProductID == id)
                    break;
                }
            }
            return View(m);
        }

        public ActionResult Edit(int id)
        {
            var product = db.Product.FirstOrDefault(p => p.ProductID == id);

            if (TryUpdateModel(product, "",
                new string[] { "ProductName", "Details" }))
                db.SaveChanges();
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