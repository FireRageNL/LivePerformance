using System.Collections.Generic;
using Bootverhuur__t_Sloepke.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Booverhuur.Testing
{
    [TestClass]
    public class VaarwaterTests
    {
        [TestMethod]
        public void TestReturnVaarwater()
        {
            List<Vaarplaats> test = Vaarplaats.GetAllVaarplaatsen("Motorboot");
            Assert.AreEqual(2,test.Count,"De hoeveelheid opgehaalde vaarplaatsen klopt niet van Motorboten");
            List<Vaarplaats> test2 = Vaarplaats.GetAllVaarplaatsen("Spierkrachtboot");
            Assert.AreEqual(0,test2.Count,"De hoeveelheid opgehaalde vaarplaatsen klopt niet van Spierkrachtboten");
        }

        [TestMethod]
        public void VaarwaterConstructorTest()
        {
            Vaarplaats vp = new Vaarplaats("Testplaats", 3);
            Assert.AreEqual(2,vp.Prijs,"De prijs klopt niet voor een nieuwe vaarplaats");
        }
    }
}
