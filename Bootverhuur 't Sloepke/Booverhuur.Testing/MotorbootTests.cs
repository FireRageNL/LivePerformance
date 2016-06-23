using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bootverhuur__t_Sloepke.Classes;

namespace Booverhuur.Testing
{
    [TestClass]
    public class MotorbootTest
    {
        [TestMethod]
        public void MotorbootPrijsTest()
        {
            Motorboot mb = new Motorboot(10,"Testboot","Testklasse");
            Assert.AreEqual(mb.Prijs,15,"Verkeerde prijs voor een motorboot!");
        }

        [TestMethod]
        public void MotorbootRadiusTest()
        {
            Motorboot mb = new Motorboot(10,"Testmb","Testklasse");
            Assert.AreEqual(mb.Actieradius,150,"Actieradius berekening gaat fout!");
        }

    }
}
