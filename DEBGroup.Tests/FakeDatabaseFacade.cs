using System;
using System.Collections.Generic;
using System.Data.Entity;
using DEBGroup.DatabaseFacade;
using DEBGroup.EF;

namespace DEBGroup.Tests
{
    public class FakeDatabaseFacade : IEAL39_DBEntities
    {
        //public List<Sector> Read()
        //{
        //    List<Sector> allSectors = new List<Sector>();
        //    allSectors.Add(new Sector() { SectorID = 1, SectorName = "Office & Facility" });
        //    allSectors.Add(new Sector() { SectorID = 2, SectorName = "Healthcare" });
        //    allSectors.Add(new Sector() { SectorID = 3, SectorName = "Industrial" });
        //    allSectors.Add(new Sector() { SectorID = 4, SectorName = "Food" });

        //    return allSectors;
        //}
        public DbSet<Category> Category
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<CustomerInfo> CustomerInfo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<Product> Product
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<Room> Room
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<SCPconnection> SCPconnection
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<Sector> Sector
        {
            get
            {
                IEnumerable<EF.Sector> returSector = new EF.Sector[]
                {
                    new Sector() { SectorID = 1, SectorName = "Office & Facility" },
                    new Sector() { SectorID = 2, SectorName = "Healthcare" },
                    new Sector() { SectorID = 3, SectorName = "Industrial" },
                    new Sector() { SectorID = 4, SectorName = "Food" }
                };
                return (DbSet<Sector>)returSector;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}