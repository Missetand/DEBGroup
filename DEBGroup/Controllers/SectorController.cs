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
            return View(db.Sector.ToList());
        }
    }
}