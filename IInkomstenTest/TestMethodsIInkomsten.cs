using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToetsApplicatie;
using System.Collections.Generic;

namespace IInkomstenTest
{
    [TestClass]
    public class TestMethodsIInkomsten
    {
        [TestMethod]
        public void myTestData()
        {
            // een lijst met IInkomsten om dan te sorteren 
            // hoe wordt het nu gesorteerd
        }
        [TestMethod]
        public void tweeFeestzalenKunnenVergelekenWorden()
        {
            DateTime datum = DateTime.Now;
            Feestzaal a = new Feestzaal(datum, 1);
            Feestzaal b = new Feestzaal(datum, 1);
            Sportzaal c = new Sportzaal(datum, 3);
            Vergaderzaal d = new Vergaderzaal(datum, 1);

            Assert.AreEqual(a, b);
            Assert.AreNotEqual(a, c);
            Assert.AreNotEqual(d, c);
            Assert.AreNotEqual(a, d);
            
        }
    }
}
