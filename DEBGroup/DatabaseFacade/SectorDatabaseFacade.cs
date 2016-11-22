using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.DatabaseFacade
{
    public class SectorDatabaseFacade
    {
        private EF.IEAL39_DBEntities _db;

        public SectorDatabaseFacade(EF.IEAL39_DBEntities db)
        {
            _db = db;
        }

        public List<EF.Sector> Read()
        {
            return _db.Sector.OrderBy(p => p.SectorName).ToList();
        }

        public EF.Sector Read(int id)
        {
            return _db.Sector.FirstOrDefault(p => p.SectorID == id);
        }
    }
}