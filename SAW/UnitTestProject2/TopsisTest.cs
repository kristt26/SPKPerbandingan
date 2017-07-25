using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TOPSIS;

namespace UnitTestProject2
{
    [TestClass]
    public class TopsisTest
    {

        [TestMethod]
        public void Matrik_Normal()
        {
            TopsisLib DataMatriksNormal = new TopsisLib();
            var MatriksNormal = DataMatriksNormal.Matriks_Normal();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void MatrikY()
        {
            TopsisLib DataMatriksY = new TopsisLib();
            var MatriksY = DataMatriksY.Matriks_Y();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Nilai_Positif()
        {
            TopsisLib DataNilaiPositif = new TopsisLib();
            var NilaiPositif = DataNilaiPositif.SolusiIdealPositif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Nilai_Negatif()
        {
            TopsisLib DataNilaiNegatif = new TopsisLib();
            var NilaiNegatif = DataNilaiNegatif.SolusiIdealNegatif();
            Assert.AreEqual(4, 4);
        }


        [TestMethod]
        public void JarakNilaiNegatif()
        {
            TopsisLib DataJarakNilaiNegatif = new TopsisLib();
            var NilaiNegatif = DataJarakNilaiNegatif.JarakNilaiIdealNegatif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void JarakNilaiPositif()
        {
            TopsisLib DataJarakNilaiPositif = new TopsisLib();
            var NilaiPositif = DataJarakNilaiPositif.JarakNilaiIdealPositif();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void SolusiAlternatif()
        {
            TopsisLib DataNilaiAlternatif = new TopsisLib();
            var NilaiAlternatif = DataNilaiAlternatif.AlternatifSolusi();
            Assert.AreEqual(NilaiAlternatif[0].NilaiAkhir<0.3923, NilaiAlternatif[0].NilaiAkhir>0.3925);
        }
    }
}
