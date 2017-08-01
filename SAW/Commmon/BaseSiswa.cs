using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class BaseSiswa:ICloneable
    {
        public string IdPendaftaran { get; set; }
        public string TahunAjaran { get; set; }
        public string NamaSiswa { get; set; }
        public string TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public JenisKelamin JK { get; set; }
        public agama Agama { get; set; }
        public StatusKeluarga statusKeluarga { get; set; }
        public string Alamat { get; set; }
        public string AsalSekolah { get; set; }
        public double NilaiAkhir { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
