using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DEBGroup.Tests
{
    [TestClass]
    public class U_SectorTest
    {
        [TestMethod]
        public void ReadAllSectorsTest()
        {
            var db = new DEBGroup.DatabaseFacade.SectorDatabaseFacade(new FakeDatabaseFacade());

            List<DEBGroup.EF.Sector> allSectors = db.Read();

            Assert.AreEqual(4, allSectors.Count);
            CollectionAssert.AllItemsAreUnique(allSectors);

        }
        [TestMethod]
        public void ReadAllSectorsTest_henten()
        {
            var db = new DEBGroup.DatabaseFacade.SectorDatabaseFacade(new FakeDatabaseFacade());

            DEBGroup.EF.Sector ens = db.Read(2);

            Assert.AreEqual("refhdk", ens.SectorName);
        }
    }
}
