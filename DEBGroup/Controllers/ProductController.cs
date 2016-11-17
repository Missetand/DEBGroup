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
            var m = new Models.Product.Index();

            m.DisplayName = "Produkter";

            foreach (var item in db.Product.OrderBy(p => p.ProductName))
            {
                var mp = new Models.Product.ModelProduct();
                mp.SectorName = item.ProductName;
                mp.ProductID = item.ProductID;
                mp.DetailsUrl = item.Details;
                m.AllProducts.Add(mp);
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


    }
}