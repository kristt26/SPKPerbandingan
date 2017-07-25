using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commmon;
using System.Collections.ObjectModel;

namespace SAW
{
    public class SimpleAdditiveWeighting
    {
        public int colls = 7;
        public int rows = 6;
        double[,] NilaiAlternatif = {
                { 1, 3, 2, 1, 5, 3, 2 },
                { 1, 2, 3, 2, 4, 2, 1 },
                { 1, 1, 4, 3, 3, 1, 2 },
                { 1, 2, 5, 4, 2, 3, 1 },
                { 1, 3, 1, 5, 3, 2, 2 },
                { 1, 1, 3, 3, 2, 1, 1 }
        };

        double[] bobot = { 0.25, 0.25, 0.10, 0.10, 0.10, 0.10, 0.10 };


        public List<SiswaMatriks> MatriksNormal()
        {
            var Matriks_Keputusan = new NilaiAlternatif_Matriks().MatriksKeputusan();
            var _NilaiAlternatif = Matriks_Keputusan.Clone().ToArray();
            foreach (var siswa in Matriks_Keputusan)
            {
                var tempSiswa = _NilaiAlternatif.Where(O => O.IdPendaftaran == siswa.IdPendaftaran).FirstOrDefault();
                tempSiswa.Kelengkapan = siswa.Kelengkapan / Matriks_Keputusan.Max(O => O.Kelengkapan);
                tempSiswa.Keahlian = siswa.Keahlian / Matriks_Keputusan.Max(O => O.Keahlian);
                tempSiswa.NilaiBahasaInggris = siswa.NilaiBahasaInggris / Matriks_Keputusan.Max(O => O.NilaiBahasaInggris);
                tempSiswa.NilaiBahasaIndonesia = siswa.NilaiBahasaIndonesia / Matriks_Keputusan.Max(O => O.NilaiBahasaIndonesia);
                tempSiswa.NilaiMatematika = siswa.NilaiMatematika / Matriks_Keputusan.Max(O => O.NilaiMatematika);
                tempSiswa.NilaiWawancara = siswa.NilaiWawancara / Matriks_Keputusan.Max(O => O.NilaiWawancara);
                tempSiswa.NilaiKesehatan = siswa.NilaiKesehatan / Matriks_Keputusan.Max(O => O.NilaiKesehatan);
            }

            return _NilaiAlternatif.ToList<SiswaMatriks>();
        }

        public List<SiswaMatriks> Hasil()
        {
            ObservableCollection<Criteria> criterias = CriteriasCollection.BaseCriteria();
            var hasil = MatriksNormal().Clone().ToArray();
            foreach (var siswa in MatriksNormal())
            {
                var tempSiswa = hasil.Where(O => O.IdPendaftaran == siswa.IdPendaftaran).FirstOrDefault();
                tempSiswa.NilaiAkhir += siswa.Kelengkapan * criterias.Where(O => O.Code == "C1").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.Keahlian * criterias.Where(O => O.Code == "C2").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.NilaiBahasaInggris * criterias.Where(O => O.Code == "C3").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.NilaiBahasaIndonesia * criterias.Where(O => O.Code == "C4").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.NilaiMatematika * criterias.Where(O => O.Code == "C5").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.NilaiWawancara * criterias.Where(O => O.Code == "C6").FirstOrDefault().Bobot;
                tempSiswa.NilaiAkhir += siswa.NilaiKesehatan * criterias.Where(O => O.Code == "C7").FirstOrDefault().Bobot;

            }
            return hasil.ToList<SiswaMatriks>();
        }

    }

}
