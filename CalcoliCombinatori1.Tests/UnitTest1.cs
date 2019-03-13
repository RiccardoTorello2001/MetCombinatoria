using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary1;

namespace CalcoliCombinatori1.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [DataTestMethod]
        [DataRow(5, 120)]
        [DataRow(1, 1)]
        [DataRow(0, 1)]
        [DataRow(10, 3628800)]
        [DataRow(20, 2432902008176640000)]

        [TestMethod]
        public void TestFatt_1(long num, long exp)
        {
            long obt = CalcoliCombinatori.Fatt(num);
            Assert.AreEqual(exp, obt);
        }

    }
}
