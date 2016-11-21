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
            DEBGroup.DatabaseFacade.IDatabaseFacadeSector dut = new FakeDatabaseFacade();

            List<DEBGroup.EF.Sector> allSectors = dut.Read();

            Assert.AreEqual(4, allSectors.Count);
            CollectionAssert.AllItemsAreUnique(allSectors);
            
        }
    }
}
