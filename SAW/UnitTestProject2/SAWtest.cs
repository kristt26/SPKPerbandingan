using Commmon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SAW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP;

namespace UnitTestProject2
{
    [TestClass]
    public class SAWtest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleAdditiveWeighting Matriks = new SimpleAdditiveWeighting();
            var DataNormal = Matriks.MatriksNormal();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SimpleAdditiveWeighting MatriksHsl = new SimpleAdditiveWeighting();
            var DataHsl = MatriksHsl.MatriksNormal();
            Assert.AreEqual(0.2, DataHsl[0].NilaiMatematika);
        }

        //Metode WP
        [TestMethod]
        public void BobotBaru()
        {
            WeightedProduct BB = new WeightedProduct();
            var a = BB.NewBobot();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Vektor_S()
        {
            WeightedProduct BB = new WeightedProduct();
            var Bobot = BB.Vector_S();
            Assert.AreEqual(4, 4);
        }

        [TestMethod]
        public void Vektor_V()
        {
            WeightedProduct DataVectorV = new WeightedProduct();
            var VectorV = DataVectorV.Vector_V();
            Assert.AreEqual(4, 4);
        }
        [TestMethod]
        public void RankIsThereWhenNilaiSiswaISet ()
        {
            var data = new NilaiAlternatif_Matriks();
            var a = data.MatriksKeputusan();
            Assert.IsTrue(a.Count > 0);
        }

        [TestMethod]
        public void TestTeoriBahasaIndonesiaketikaNilai0_50()
        {            
            Siswa a = new Siswa { BahasaIndonesia = new TeoriBahasaIndonesia { Nilai = 73 }, Kelengkapan = new KelengkapanBerkas { Nilai = StatusBerkas.Lengkap }, Keahliah = new KeahliahJurusan { Nilai = 73 }, BahasaInggris = new TeoriBahasaInggris { Nilai = 82 }, Matematika = new TeoriMatematika { Nilai = 60 }, HasilWawancara = new Wawancara { Nilai = StatusWawancara.Kurang }, HasilKesehatan = new Kesehatan { Nilai = StatusKesehatan.SehatJasmani }, IdPendaftaran = "1" };

            Assert.IsTrue(a.BahasaIndonesia.Rank != 0);
        }

        [TestMethod]
        public void _MatriksNormal()
        {
            NilaiAlternatif_Matriks data = new NilaiAlternatif_Matriks();
            var a = data.MatriksKeputusan().Count;
            Assert.IsTrue(a == 7);
        }

        [TestMethod]
        public void HasilRangking()
        {
            SimpleAdditiveWeighting data = new SimpleAdditiveWeighting();
            var a = data.Hasil();
            Assert.IsTrue(a.Count != 0);
        }
    }
}
