using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commmon
{
    public static class CriteriasCollection
    {

        public static ObservableCollection<Criteria> Get()
        {
            var Cristerias = new ObservableCollection<Criteria>();
            
            //instance Criteria 
            var c1 = new Criteria { Id = 1, Code = "C1", Bobot = 0.25 ,TypeAlternative=typeof(KelengkapanBerkas)};
            var c2 = new Criteria { Id = 2, Code = "C2", Bobot = 0.25, TypeAlternative = typeof(KeahliahJurusan) };
            var c3 = new Criteria { Id = 3, Code = "C3", Bobot = 0.1, TypeAlternative = typeof(TeoriBahasaInggris) };
            var c4 = new Criteria { Id = 4, Code = "C4", Bobot = 0.1, TypeAlternative = typeof(TeoriBahasaIndonesia) };
            var c5 = new Criteria { Id = 5, Code = "C5", Bobot = 0.1 , TypeAlternative = typeof(TeoriMatematika) };
            var c6 = new Criteria { Id = 6, Code = "C6", Bobot = 0.1, TypeAlternative = typeof(Wawancara) };
            var c7 = new Criteria { Id = 7, Code = "C7", Bobot = 0.1 , TypeAlternative = typeof(Kesehatan) };

            //instance  Alterntive and inisialisasi to criteria 
            /*c1.Alternatives = new ObservableCollection<Alternative>();
            c1.Alternatives.Add(new Alternative {})
            c2.Alternatives = new ObservableCollection<Alternative>();
            c3.Alternatives = new ObservableCollection<Alternative>();
            c4.Alternatives = new ObservableCollection<Alternative>();
            c5.Alternatives = new ObservableCollection<Alternative>();
            c6.Alternatives = new ObservableCollection<Alternative>();
            c7.Alternatives = new ObservableCollection<Alternative>();*/


            //Inisialisasi Criteria To  Criterias
            Cristerias.Add(c1);
            Cristerias.Add(c2);
            Cristerias.Add(c3);
            Cristerias.Add(c4);
            Cristerias.Add(c5);
            Cristerias.Add(c6);
            Cristerias.Add(c7);
            List<Siswa> Siswas = new List<Siswa> {
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=70 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=70 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=40}, Matematika=new TeoriMatematika{ Nilai= 60}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Kurang}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani } },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=70 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=70 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=40}, Matematika=new TeoriMatematika{ Nilai= 60}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Kurang}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani } }
        };

            foreach(var criteria in Cristerias)
            {
                criteria.Alternatives = new ObservableCollection<Alternative>();
                foreach(Siswa siswa in Siswas)
                {
                    var propertiesOfSiswa = siswa.GetType().GetProperties();
                    var alternatifProp = propertiesOfSiswa.Where(O => O.PropertyType.Name == criteria.TypeAlternative.Name).FirstOrDefault();
                    object aa =Activator.CreateInstance(alternatifProp.PropertyType);
                    Alternative al =(Alternative) alternatifProp.GetValue(siswa,null);
                    al.CriteriaCode = criteria.Code;
                    al.IdPendaftaran = siswa.IdPendaftaran;
                    criteria.Alternatives.Add(al);
                }
            }


            return Cristerias;
        }

        public static Criteria GetById(int id)
        {
          return  CriteriasCollection.Get().Where(O => O.Id == id).FirstOrDefault();
        }
    }
}
