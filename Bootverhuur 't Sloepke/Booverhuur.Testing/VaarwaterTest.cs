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
            List<Vaarplaats> test2 = Vaarplaats.GetAllVaarplaatsen("Spierkrachtboot");
            Assert.AreEqual(0,test2.Count,"De hoeveelheid opgehaalde vaarplaatsen klopt niet van Spierkrachtboten");
        }

        [TestMethod]
        public void VaarwaterConstructorTest()
        {
            Vaarplaats vp = new Vaarplaats("Testplaats", 3);
            Assert.AreEqual(2,vp.Prijs,"De prijs klopt niet voor een nieuwe vaarplaats");
        }

        [TestMethod]
        public void AddVaarwaterTest()
        {
            Vaarplaats vp = new Vaarplaats();
            List<Vaarplaats> Before = Vaarplaats.GetAllVaarplaatsen("Motorboot");
            int count = Before.Count;
            vp.AddVaarplaats("Testplaats1");
            List<Vaarplaats> After = Vaarplaats.GetAllVaarplaatsen("Motorboot");
            Assert.AreEqual((count+1),After.Count,"Testplaats is niet juist toegevoegd!");
        }
    }
}
