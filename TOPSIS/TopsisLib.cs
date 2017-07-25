using Commmon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPSIS
{
    public class TopsisLib
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
        public List<SiswaMatriks> Matriks_Normal()
        {
            var MatriksKeputusan = new NilaiAlternatif_Matriks().MatriksKeputusan();
            List<SiswaMatriks> MatriksPangkat = MatriksKeputusan.Clone().ToList();
            foreach(var indekspangkat in MatriksKeputusan)
            {
                var tempindex = MatriksPangkat.Where(O => O.IdPendaftaran == indekspangkat.IdPendaftaran).FirstOrDefault();
                tempindex.Kelengkapan = Math.Pow(indekspangkat.Kelengkapan, 2);
                tempindex.Keahlian = Math.Pow(indekspangkat.Keahlian, 2);
                tempindex.NilaiBahasaInggris = Math.Pow(indekspangkat.NilaiBahasaInggris, 2);
                tempindex.NilaiBahasaIndonesia = Math.Pow(indekspangkat.NilaiBahasaIndonesia, 2);
                tempindex.NilaiMatematika = Math.Pow(indekspangkat.NilaiMatematika, 2);
                tempindex.NilaiWawancara = Math.Pow(indekspangkat.NilaiWawancara, 2);
                tempindex.NilaiKesehatan = Math.Pow(indekspangkat.NilaiKesehatan, 2);
            }

           var  NewMatriks = MatriksPangkat.Clone().ToArray();
            foreach (var siswa in MatriksKeputusan)
            {
                var temptsiswa = NewMatriks.Where(O => O.IdPendaftaran == siswa.IdPendaftaran).FirstOrDefault();
                temptsiswa.Kelengkapan = siswa.Kelengkapan / Math.Sqrt(MatriksPangkat.Sum(O => O.Kelengkapan));
                temptsiswa.Keahlian = siswa.Keahlian / Math.Sqrt(MatriksPangkat.Sum(O => O.Keahlian));
                temptsiswa.NilaiBahasaInggris = siswa.NilaiBahasaInggris / Math.Sqrt(MatriksPangkat.Sum(o => o.NilaiBahasaInggris));
                temptsiswa.NilaiBahasaIndonesia = siswa.NilaiBahasaIndonesia / Math.Sqrt(MatriksPangkat.Sum(o => o.NilaiBahasaIndonesia));
                temptsiswa.NilaiMatematika = siswa.NilaiMatematika / Math.Sqrt(MatriksPangkat.Sum(o => o.NilaiMatematika));
                temptsiswa.NilaiWawancara = siswa.NilaiWawancara / Math.Sqrt(MatriksPangkat.Sum(o => o.NilaiWawancara));
                temptsiswa.NilaiKesehatan = siswa.NilaiKesehatan / Math.Sqrt(MatriksPangkat.Sum(o => o.NilaiKesehatan));
            }
            return NewMatriks.ToList();

        }

        public List<SiswaMatriks> Matriks_Y()
        {
            var NewMatriks = Matriks_Normal();
            ObservableCollection<Criteria> criterias = CriteriasCollection.BaseCriteria();
            var MatriksY = NewMatriks.Clone().ToArray();
            foreach(var siswa in NewMatriks)
            {
                var a = siswa.MaxOfProperty();
                var tempsiswa = MatriksY.Where(O => O.IdPendaftaran == siswa.IdPendaftaran).FirstOrDefault();
                tempsiswa.Kelengkapan = siswa.Kelengkapan * criterias.Where(O => O.Code == "C1").FirstOrDefault().Bobot;
                tempsiswa.Keahlian = siswa.Keahlian * criterias.Where(O => O.Code == "C2").FirstOrDefault().Bobot;
                tempsiswa.NilaiBahasaInggris = siswa.NilaiBahasaInggris * criterias.Where(O => O.Code == "C3").FirstOrDefault().Bobot;
                tempsiswa.NilaiBahasaIndonesia = siswa.NilaiBahasaIndonesia * criterias.Where(O => O.Code == "C4").FirstOrDefault().Bobot;
                tempsiswa.NilaiMatematika = siswa.NilaiMatematika * criterias.Where(O => O.Code == "C5").FirstOrDefault().Bobot;
                tempsiswa.NilaiWawancara = siswa.NilaiWawancara * criterias.Where(O => O.Code == "C6").FirstOrDefault().Bobot;
                tempsiswa.NilaiKesehatan = siswa.NilaiKesehatan * criterias.Where(O => O.Code == "C7").FirstOrDefault().Bobot;
            }
            return MatriksY.ToList();
        }

        public IList<Criteria> SolusiIdealPositif ()
        {
            var criteria = CriteriasCollection.BaseCriteria().Clone().ToArray();
            foreach (var item in criteria)
            {
                if (item.Code == "C1")
                    item.Bobot = Matriks_Y().Max(O => O.Kelengkapan);
                else if (item.Code == "C2")
                    item.Bobot = item.Bobot = Matriks_Y().Max(O => O.Keahlian);
                else if (item.Code == "C3")
                    item.Bobot = Matriks_Y().Max(O => O.NilaiBahasaInggris);
                else if (item.Code == "C4")
                    item.Bobot = Matriks_Y().Max(O => O.NilaiBahasaIndonesia);
                else if (item.Code == "C5")
                    item.Bobot = Matriks_Y().Max(O => O.NilaiMatematika);
                else if (item.Code == "C6")
                    item.Bobot = Matriks_Y().Max(O => O.NilaiWawancara);
                else
                    item.Bobot = Matriks_Y().Max(O => O.NilaiKesehatan);
            }
            return criteria.ToList();
        }

        public IList<Criteria> SolusiIdealNegatif()
        {
            var criteria = CriteriasCollection.BaseCriteria().Clone().ToArray();
            foreach (var item in criteria)
            {
                if (item.Code == "C1")
                    item.Bobot = Matriks_Y().Min(O => O.Kelengkapan);
                else if (item.Code == "C2")
                    item.Bobot = item.Bobot = Matriks_Y().Min(O => O.Keahlian);
                else if (item.Code == "C3")
                    item.Bobot = Matriks_Y().Min(O => O.NilaiBahasaInggris);
                else if (item.Code == "C4")
                    item.Bobot = Matriks_Y().Min(O => O.NilaiBahasaIndonesia);
                else if (item.Code == "C5")
                    item.Bobot = Matriks_Y().Min(O => O.NilaiMatematika);
                else if (item.Code == "C6")
                    item.Bobot = Matriks_Y().Min(O => O.NilaiWawancara);
                else
                    item.Bobot = Matriks_Y().Min(O => O.NilaiKesehatan);
            }
            return criteria.ToList();
        }

        public IList<SiswaMatriks> JarakNilaiIdealPositif()
        {            
            var criteria = Matriks_Y().Clone().ToArray();
            foreach(var item in Matriks_Y())
            {
                var tempitem = criteria.Where(O => O.IdPendaftaran == item.IdPendaftaran).FirstOrDefault();
                tempitem.Kelengkapan = Math.Pow(item.Kelengkapan - SolusiIdealPositif().Where(O => O.Code == "C1").FirstOrDefault().Bobot,2);
                tempitem.Keahlian = Math.Pow(item.Keahlian - SolusiIdealPositif().Where(O => O.Code == "C2").FirstOrDefault().Bobot, 2);
                tempitem.NilaiBahasaInggris = Math.Pow(item.NilaiBahasaInggris - SolusiIdealPositif().Where(O => O.Code == "C3").FirstOrDefault().Bobot, 2);
                tempitem.NilaiBahasaIndonesia = Math.Pow(item.NilaiBahasaIndonesia - SolusiIdealPositif().Where(O => O.Code == "C4").FirstOrDefault().Bobot, 2);
                tempitem.NilaiMatematika = Math.Pow(item.NilaiMatematika - SolusiIdealPositif().Where(O => O.Code == "C5").FirstOrDefault().Bobot, 2);
                tempitem.NilaiWawancara= Math.Pow(item.NilaiWawancara - SolusiIdealPositif().Where(O => O.Code == "C6").FirstOrDefault().Bobot, 2);
                tempitem.NilaiKesehatan = Math.Pow(item.NilaiKesehatan - SolusiIdealPositif().Where(O => O.Code == "C7").FirstOrDefault().Bobot, 2);
                tempitem.NilaiAkhir = Math.Sqrt(tempitem.Kelengkapan + tempitem.Keahlian + tempitem.NilaiBahasaInggris + tempitem.NilaiBahasaIndonesia + tempitem.NilaiMatematika + tempitem.NilaiWawancara + tempitem.NilaiKesehatan);

            }
            return criteria.ToList();
        }

        public IList<SiswaMatriks> JarakNilaiIdealNegatif()
        {

            var criteria = Matriks_Y().Clone().ToArray();
            foreach (var item in Matriks_Y())
            {
                var tempitem = criteria.Where(O => O.IdPendaftaran == item.IdPendaftaran).FirstOrDefault();
                tempitem.Kelengkapan = Math.Pow(item.Kelengkapan - SolusiIdealNegatif().Where(O => O.Code == "C1").FirstOrDefault().Bobot, 2);
                tempitem.Keahlian = Math.Pow(item.Keahlian - SolusiIdealNegatif().Where(O => O.Code == "C2").FirstOrDefault().Bobot, 2);
                tempitem.NilaiBahasaInggris = Math.Pow(item.NilaiBahasaInggris - SolusiIdealNegatif().Where(O => O.Code == "C3").FirstOrDefault().Bobot, 2);
                tempitem.NilaiBahasaIndonesia = Math.Pow(item.NilaiBahasaIndonesia - SolusiIdealNegatif().Where(O => O.Code == "C4").FirstOrDefault().Bobot, 2);
                tempitem.NilaiMatematika = Math.Pow(item.NilaiMatematika - SolusiIdealNegatif().Where(O => O.Code == "C5").FirstOrDefault().Bobot, 2);
                tempitem.NilaiWawancara = Math.Pow(item.NilaiWawancara - SolusiIdealNegatif().Where(O => O.Code == "C6").FirstOrDefault().Bobot, 2);
                tempitem.NilaiKesehatan = Math.Pow(item.NilaiKesehatan - SolusiIdealNegatif().Where(O => O.Code == "C7").FirstOrDefault().Bobot, 2);
                tempitem.NilaiAkhir = Math.Sqrt(tempitem.Kelengkapan + tempitem.Keahlian + tempitem.NilaiBahasaInggris + tempitem.NilaiBahasaIndonesia + tempitem.NilaiMatematika + tempitem.NilaiWawancara + tempitem.NilaiKesehatan);

            }
            return criteria.ToList();
        }

        public List<BaseSiswa> AlternatifSolusi()
        {
            List<BaseSiswa> Hasil = new List<BaseSiswa>();
            var NilaiPositif = JarakNilaiIdealPositif().Clone().ToArray();
            foreach(var item in JarakNilaiIdealNegatif())
            {                
                var Tempitem = NilaiPositif.Where(O => O.IdPendaftaran == item.IdPendaftaran).FirstOrDefault();
                Tempitem.NilaiAkhir = item.NilaiAkhir / (NilaiPositif.Where(O => O.IdPendaftaran == item.IdPendaftaran).FirstOrDefault().NilaiAkhir + item.NilaiAkhir);
                var siswa = new BaseSiswa();
                siswa.IdPendaftaran = item.IdPendaftaran;
                siswa.NilaiAkhir = Tempitem.NilaiAkhir;
                Hasil.Add(siswa);
            }
            return Hasil.ToList();
        }

        public double Nilai_X(double[] data)
        {
            double awal = new double();
            foreach (var item in data)
            {
                awal += (Math.Pow(item, 2));
            }
            double Nx = Math.Sqrt(awal);
            return Nx;
        }
    }

   
    
}
