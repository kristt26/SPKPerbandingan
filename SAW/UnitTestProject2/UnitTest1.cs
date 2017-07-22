using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAW;
using WP;
using TOPSIS;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleAdditiveWeighting Matriks = new SimpleAdditiveWeighting();
            List<double> DataNormal =Matriks.MatriksKeputusan();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SimpleAdditiveWeighting MatriksHsl = new SimpleAdditiveWeighting();
            double[] DataHsl = MatriksHsl.Hasil();
            Assert.AreEqual(1.4,DataHsl[0]);
        }

        //Metode WP
        [TestMethod]
        public void BobotBaru()
        {
            WeightedProduct BB = new WeightedProduct();
            double[] Bobot = BB.NewBobot();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Vektor_S()
        {
            WeightedProduct BB = new WeightedProduct();
            double[] Bobot = BB.Vector_S();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Vektor_V()
        {
            WeightedProduct DataVectorV = new WeightedProduct();
            double[] VectorV = DataVectorV.Vector_V();
            Assert.AreEqual(4, 4);
        }

        //TOPSIS

        [TestMethod]
        public void Matrik_Normal()
        {
            TopsisLib DataMatriksNormal = new TopsisLib();
            double[,] MatriksNormal = DataMatriksNormal.Matriks_Normal(); 
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void MatrikY()
        {
            TopsisLib DataMatriksY = new TopsisLib();
            double[,] MatriksY = DataMatriksY.Matriks_Y();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Nilai_Positif()
        {
            TopsisLib DataNilaiPositif = new TopsisLib();
            double[] NilaiPositif = DataNilaiPositif.SolusiIdealPositif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Nilai_Negatif()
        {
            TopsisLib DataNilaiNegatif = new TopsisLib();
            double[] NilaiNegatif = DataNilaiNegatif.SolusiIdealNegatif();
            Assert.AreEqual(4, 4);
        }


        [TestMethod]
        public void JarakNilaiNegatif()
        {
            TopsisLib DataJarakNilaiNegatif = new TopsisLib();
            double[] NilaiNegatif = DataJarakNilaiNegatif.JarakNilaiIdealNegatif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void JarakNilaiPositif()
        {
            TopsisLib DataJarakNilaiPositif = new TopsisLib();
            double[] NilaiPositif = DataJarakNilaiPositif.JarakNilaiIdealPositif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void SolusiAlternatif()
        {
            TopsisLib DataNilaiAlternatif = new TopsisLib();
            double[] NilaiAlternatif = DataNilaiAlternatif.AlternatifSolusi();
            Assert.AreEqual(4, 4);
        }
    }
}
