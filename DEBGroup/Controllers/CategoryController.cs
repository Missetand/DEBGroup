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

            // select * from sector where sectorid = 1
            m.DisplayName = db.Sector.FirstOrDefault(p => p.SectorID == id).SectorName;
            m.SectorID = id;

            // select distinct CategoryName, s.CategoryID from SCPconnection s, Category g where s.SectorID = 1 and s.CategoryID = g.CategoryID
            var allCategoryID = db.SCPconnection.Where(p => p.SectorID == id).Select(p => p.CategoryID).Distinct();
            foreach (var CategoryID in allCategoryID)
            {
                var mc = new Models.Category.ModelCategory();
                var c = db.Category.FirstOrDefault(p => p.CategoryID == CategoryID);

                mc.CategoryName = c.CategoryName;
                mc.CategoryID = c.CategoryID;
                m.AllCategories.Add(mc);
            }

            return View(m);
        }
        public ActionResult Edit(int id)
        {
            var category = db.Category.FirstOrDefault(c => c.CategoryID == id);

            if (TryUpdateModel(category, "",
                new string[] { "CategoryName" }))
                db.SaveChanges();
            return View(category);
        }
    }
}