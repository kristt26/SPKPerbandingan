using Commmon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    [TestClass]
    public class SAWtest
    {
        [TestMethod]
        public void RankIsThereWhenNilaiSiswaISet ()
        {
            var data = new SAW.SimpleAdditiveWeighting();
            var a = data.MatriksKeputusan();
            Assert.IsTrue(a.Count > 0);
        }

        [TestMethod]
        public void TestTeoriBahasaIndonesiaketikaNilai0_50()
        {            
            Siswa a = new Siswa { BahasaIndonesia = new TeoriBahasaIndonesia { Nilai = 73 }, Kelengkapan = new KelengkapanBerkas { Nilai = StatusBerkas.Lengkap }, Keahliah = new KeahliahJurusan { Nilai = 73 }, BahasaInggris = new TeoriBahasaInggris { Nilai = 82 }, Matematika = new TeoriMatematika { Nilai = 60 }, HasilWawancara = new Wawancara { Nilai = StatusWawancara.Kurang }, HasilKesehatan = new Kesehatan { Nilai = StatusKesehatan.SehatJasmani }, IdPendaftaran = 1 };

            Assert.IsTrue(a.BahasaIndonesia.Rank != 0);
        }
    }
}
