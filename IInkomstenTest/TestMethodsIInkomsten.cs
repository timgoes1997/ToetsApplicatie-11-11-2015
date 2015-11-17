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
        public void TestOngespecifeerd()
        {
            //Arrange
            Administratie admin = new Administratie();
            // TODO je gaat ook 10 producten gaan verkopen en uitlenen

            //Act
            List<IInkomsten> inkomsten = admin.Overzicht(BTWTarief.Ongespecifeerd);
            //Assert
            foreach (IInkomsten i in inkomsten)
            {
                //ik weet niet precies wat ik hier moet doen met Assert.AreEqual aangezien BTWTarief i.p.v Ongespecificeerd ook nog Hoog en Laag kan zijn.
                Assert.IsNotNull(i);
            }

        }
    }
}
