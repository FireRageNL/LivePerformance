using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootverhuur__t_Sloepke.Classes;
using Bootverhuur__t_Sloepke.Database;

namespace Booverhuur.Testing
{
    [TestClass]
    public class HuurTests
    {
        [TestMethod]
        public void GetBoatTypesTest()
        {
            List<string> types = Boot.GetTypes();
            Assert.AreEqual(2,types.Count,"Verkeerd aantal types opgehaald uit database!");
        }

        [TestMethod]
        public void GetAllMotorboatTest()
        {
            List<Boot> boten = Boot.GetBoats("Motorboot");
            Assert.AreEqual(4,boten.Count,"Verkeerd aantal motorboten uit de database opgehaald!");
        }
        [TestMethod]
        public void GetAllSpierBoatTest()
        {
            List<Boot> boten = Boot.GetBoats("Spierkrachtboot");
            Assert.AreEqual(10, boten.Count, "Verkeerd aantal spierkrachtboten uit de database opgehaald!");
        }
        [TestMethod]
        public void GetMaterialTest()
        {
            List<Materiaal> mat = Materiaal.GetAllMateriaal();
            Assert.AreEqual(10,mat.Count,"Verkeerd aantal materialen uit de database opgehaald!");
        }

        [TestMethod]
        public void BerekenTest()
        {
            Motorboot mb = new Motorboot(10, "Testboot", "Testklasse");

            Huur hr = new Huur
            {
                HuurBegin = DateTime.Now,
                HuurEind = DateTime.Now,
                Boot = mb
            };
            hr.CalculateVaarplaatsen(17);
            Assert.AreEqual(11,hr.Meeren,"Verkeerde berekening!");
            hr.CalculateVaarplaatsen(19);
            Assert.AreEqual(12,hr.Meeren,"Verkeerde afronding!");

        }
    }
}
