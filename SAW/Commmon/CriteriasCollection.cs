using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public static class CriteriasCollection
    {
        public static List<Siswa> DataSiswa()
        {
            List<Siswa> Siswas = new List<Siswa> {
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=73 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=73 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=82}, Matematika=new TeoriMatematika{ Nilai= 60}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Kurang}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani }, IdPendaftaran=1 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=92 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=94 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=64}, Matematika=new TeoriMatematika{ Nilai= 50}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Cukup}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani }, IdPendaftaran=2 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=85 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=82 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=80}, Matematika=new TeoriMatematika{ Nilai= 70}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Tidak}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.Sehat }, IdPendaftaran=3 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=65 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=76 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=50}, Matematika=new TeoriMatematika{ Nilai= 91}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Siap}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.Sehat}, IdPendaftaran=4 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=94 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=92 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=70}, Matematika=new TeoriMatematika{ Nilai= 71}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Kurang}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani}, IdPendaftaran=5 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=83 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=80 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=53}, Matematika=new TeoriMatematika{ Nilai= 80}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Cukup}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.Tidak}, IdPendaftaran=6 },
                new Siswa{ BahasaIndonesia=new TeoriBahasaIndonesia{ Nilai=55 }, Kelengkapan=new KelengkapanBerkas{Nilai= StatusBerkas.Lengkap }, Keahliah=new KeahliahJurusan{Nilai=86 }, BahasaInggris=new TeoriBahasaInggris{ Nilai=93}, Matematika=new TeoriMatematika{ Nilai= 60}, HasilWawancara=new Wawancara{ Nilai=StatusWawancara.Tidak}, HasilKesehatan= new Kesehatan{Nilai= StatusKesehatan.SehatJasmani}, IdPendaftaran=7 }
        };
            return Siswas;
        }

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
           

            return Cristerias;
        }

        public static Criteria GetById(int id)
        {
          return  CriteriasCollection.Get().Where(O => O.Id == id).FirstOrDefault();
        }
    }
}
