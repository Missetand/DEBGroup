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
        public ActionResult Index(int id)
        {
            var m = new Models.Category.Index();

            m.DisplayName = "Categories";
            

                foreach (var item in db.Category.OrderBy(c => c.CategoryName))
                {
                    var mc = new Models.Category.ModelCategory();
                    mc.CategoryName = item.CategoryName;
                    mc.CategoryID = item.CategoryID;
                    m.AllCategories.Add(mc);
                    if (item.CategoryID == id)
                    break;
            }
            return View(m);
        }
    }
}