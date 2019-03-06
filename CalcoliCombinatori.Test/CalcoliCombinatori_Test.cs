using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace CalcoliCombinatori.Test
{
    [TestClass]
    public class CalcoliCombinatori_Test
    {
        [DataTestMethod]
        [DataRow(5,120)]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]
        
        [TestMethod]
        public void TestFatt1(int num, int Fact)
        {
            long obt = EquazioniLibrary.CalcoliCombinatori.Fattoriale(num);
            Assert.AreEqual(obt,Fact);
        }

    }
}
