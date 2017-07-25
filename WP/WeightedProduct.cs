using Commmon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP
{
    public class WeightedProduct
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
        double[] bobot = { 0.25, 0.25, 0.1, 0.1, 0.1, 0.1, 0.1 };

        public ObservableCollection<Criteria> NewBobot()
        {
            ObservableCollection<Criteria> criterias = CriteriasCollection.BaseCriteria();
            var NewCriteria = criterias.Clone().ToArray();
            foreach (var _bobot in criterias)
            {
                var tempbobot = NewCriteria.Where(O => O.Code == _bobot.Code).FirstOrDefault();
                tempbobot.Bobot = _bobot.Bobot / NewCriteria.Sum(O=>O.Bobot);
            }
            
            return criterias;
        }

        //Vektor S
        public List<BaseSiswa> Vector_S()
        {
            var Matriks_Keputusan = new NilaiAlternatif_Matriks().MatriksKeputusan();
            var _Matriks_keputusan = Matriks_Keputusan.Clone().ToArray();
            ObservableCollection<Criteria> NBobot = NewBobot();
            List<BaseSiswa> _BaseSiswa = new List<BaseSiswa>();
            foreach(var matriks in Matriks_Keputusan)
            {
                var tempmatriks = _Matriks_keputusan.Where(O => O.IdPendaftaran == matriks.IdPendaftaran).FirstOrDefault();
                tempmatriks.Kelengkapan = Math.Pow(matriks.Kelengkapan, NBobot.Where(O => O.Code == "C1").FirstOrDefault().Bobot);
                tempmatriks.Keahlian = Math.Pow(matriks.Keahlian, NBobot.Where(O => O.Code == "C2").FirstOrDefault().Bobot);
                tempmatriks.NilaiBahasaInggris = Math.Pow(matriks.NilaiBahasaInggris, NBobot.Where(O => O.Code == "C3").FirstOrDefault().Bobot);
                tempmatriks.NilaiBahasaIndonesia = Math.Pow(matriks.NilaiBahasaIndonesia, NBobot.Where(O => O.Code == "C4").FirstOrDefault().Bobot);
                tempmatriks.NilaiMatematika= Math.Pow(matriks.NilaiMatematika, NBobot.Where(O => O.Code == "C5").FirstOrDefault().Bobot);
                tempmatriks.NilaiWawancara= Math.Pow(matriks.NilaiWawancara, NBobot.Where(O => O.Code == "C6").FirstOrDefault().Bobot);
                tempmatriks.NilaiKesehatan= Math.Pow(matriks.NilaiKesehatan, NBobot.Where(O => O.Code == "C7").FirstOrDefault().Bobot);

                var siswa = new BaseSiswa();
                siswa.IdPendaftaran = tempmatriks.IdPendaftaran;
                siswa.NilaiAkhir = tempmatriks.Keahlian * tempmatriks.Keahlian * tempmatriks.NilaiBahasaInggris * tempmatriks.NilaiBahasaIndonesia * tempmatriks.NilaiMatematika * tempmatriks.NilaiWawancara * tempmatriks.NilaiKesehatan;
                _BaseSiswa.Add(siswa);
            }
            
            return _BaseSiswa;

        }

        public List<BaseSiswa> Vector_V()
        {
            List<BaseSiswa> vektorS = Vector_S();
            BaseSiswa[] _vectorS = vektorS.Clone().ToArray();
            foreach(var siswa in vektorS)
            {
                var vektorV = vektorS.Where(O => O.IdPendaftaran == siswa.IdPendaftaran).FirstOrDefault();
                vektorV.NilaiAkhir = siswa.NilaiAkhir / vektorS.Sum(O => O.NilaiAkhir);
            }
           
            return _vectorS.ToList();
        }
    }
}
