using System;
using System.Collections.Generic;
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
             EF.Product p = new EF.Product();
             id = p.ProductID;
            return View();
        }
    }
}