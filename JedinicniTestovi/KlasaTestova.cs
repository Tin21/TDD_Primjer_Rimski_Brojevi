using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimjerTDD_a_RimskiBrojevi;
using System;

namespace JedinicniTestovi
{
    [TestClass]
    public class KlasaTestova
    {
        [TestMethod]
        public void Test_Pretvaranja_Broja_1_U_Rimski()
        {
            Konverter konverter = new Konverter();
            string rimski = konverter.Pretvori(1);
            Assert.AreEqual(rimski, "I");
        }

        [TestMethod]
        public void Test_Pretvaranja_Broja_2_U_Rimski()
        {
            Konverter konverter = new Konverter();
            string rimski = konverter.Pretvori(2);
            Assert.AreEqual(rimski, "II");
        } 
    }
}
