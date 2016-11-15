using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEBGroup.Controllers
{
    public class CategoryController : Controller
    {
        EF.EAL39_DBEntities db = new EF.EAL39_DBEntities();
        // GET: Category
        public ActionResult Index()
        {
            return View(db.Category.ToList());
        }
    }
}