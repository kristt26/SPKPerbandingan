using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public  class Siswa
    {       
        public KelengkapanBerkas Kelengkapan{ get; set; }
        public KeahliahJurusan Keahliah { get; set; }
        public TeoriBahasaInggris BahasaInggris { get; set; }
        public TeoriBahasaIndonesia BahasaIndonesia { get; set; }
        public TeoriMatematika Matematika { get; set; }
        public Wawancara HasilWawancara { get; set; }
        public Kesehatan HasilKesehatan { get; set; }
        public int IdPendaftaran { get; set; }
        public Siswa()
        {
        }
    }
}
