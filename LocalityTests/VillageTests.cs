using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba3;


namespace LocalityTests
{
    [TestClass]
    public class VillageTests
    {
        [TestMethod]
        public void Density_Village()
        {
            Village misto = new Village("Село", 150, 3, 50);
            double expectedDensity = 9;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
        [TestMethod]
        public void Density_Village1()
        {
            Village misto = new Village("Село", 3000, 100, 1000);
            double expectedDensity = 300;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
        [TestMethod]
        public void Density_Village2()
        {
            Village misto = new Village("Село", 3, 1, 3);
            double expectedDensity = 1;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
    }
}