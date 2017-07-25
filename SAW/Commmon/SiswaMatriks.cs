using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class SiswaMatriks:ICloneable
    {
        public double Kelengkapan { get; set; }
        public double Keahlian { get; set; }
        public double NilaiBahasaInggris { get; set; }
        public double NilaiBahasaIndonesia { get; set; }
        public double NilaiMatematika { get; set; }
        public double NilaiWawancara { get; set; }
        public double NilaiKesehatan { get; set; }
        public string IdPendaftaran { get; set; }
        public double NilaiAkhir { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
