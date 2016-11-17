using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEBGroup.Controllers
{
    public class SectorController : Controller
    {
        EF.EAL39_DBEntities db = new EF.EAL39_DBEntities();
        // GET: Sector
        public ActionResult Index()
        {
            var m = new Models.Sector.Index();

            m.DisplayName = "Sectors";

            foreach (var item in db.Sector.OrderBy(s => s.SectorName))
            {
                var ms = new Models.Sector.ModelSector();
                ms.SectorName = item.SectorName;
                ms.SectorID = item.SectorID;
                m.AllSectors.Add(ms);
            }

            return View(m);
        }
    }
}