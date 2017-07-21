using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public  class Siswa
    {       
        public KelengkapanBerkas KelengkapanBerkas { get; set; }
        public KeahliahJurusan KeahliahJurusan { get; set; }
        public TeoriBahasaInggris TeoriBahasaInggris { get; set; }
        public TeoriBahasaIndonesia TeoriBahasaIndonesia { get; set; }
        public TeoriMatematika TeoriMatematika { get; set; }
        public Wawancara Wawancara { get; set; }
        public Kesehatan Kesehatan { get; set; }
    }
}
