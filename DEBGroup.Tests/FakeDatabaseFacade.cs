using System;
using System.Collections.Generic;
using DEBGroup.DatabaseFacade;
using DEBGroup.EF;

namespace DEBGroup.Tests
{
    internal class FakeDatabaseFacade : IDatabaseFacadeSector
    {
        public List<Sector> Read()
        {
            List<Sector> allSectors = new List<Sector>();
            allSectors.Add(new Sector() { SectorID = 1, SectorName = "Office & Facility" });
            allSectors.Add(new Sector() { SectorID = 2, SectorName = "Healthcare" });
            allSectors.Add(new Sector() { SectorID = 3, SectorName = "Industrial" });
            allSectors.Add(new Sector() { SectorID = 4, SectorName = "Food" });

            return allSectors;
        }
    }
}