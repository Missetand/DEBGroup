using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DEBGroup.Models.Sector
{
    public class Index
    {
        public List<ModelSector> AllSectors { get; set; }

        public string DisplayName { get; set; } 

        public Index()
        {
            AllSectors = new List<ModelSector>();
        }
    }

        public class ModelSector
        {
            public string SectorName { get; set; }
            public int SectorID { get; set; }

        }
}
