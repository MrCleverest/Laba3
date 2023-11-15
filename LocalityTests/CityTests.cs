using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Laba3;


namespace LocalityTests
{
    [TestClass]
    public class CityTests
    {
        [TestMethod]
        public void Density_City()
        {
            City misto = new City("Місто", 150, 3, 50);
            double expectedDensity = 9;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
        [TestMethod]
        public void Density_City1()
        {
            City misto = new City("Місто", 3000, 100, 1000);
            double expectedDensity = 300;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
        [TestMethod]
        public void Density_City2()
        {
            City misto = new City("Місто", 3, 1, 3);
            double expectedDensity = 1;

            double actualDensity = misto.PopulationDensity();

            Assert.AreEqual(expectedDensity, actualDensity);
        }
    }
}