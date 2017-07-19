using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAW;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 Matriks = new Class1();
            double[,] DataNormal = Matriks.MatriksKeputusan();
            Assert.AreEqual(DataNormal[0, 0], DataNormal[1, 0]);
        }
    }
}
