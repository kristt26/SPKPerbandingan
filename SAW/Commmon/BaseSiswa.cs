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
        public DateTime Tanggal_lahir { get; set; }
        public JenisKelamin JK { get; set; }
        public Agama agama { get; set; }
        public StatusKeluarga statusKeluarga { get; set; }
        public string Alamat { get; set; }
        public string AsalSekolah { get; set; }
        public string NamaAyah { get; set; }
        public string PekerjaanAyah { get; set; }
        public string NamaIbu { get; set; }
        public string PekerjaanIbu { get; set; }
        public string Kontak { get; set; }
        public string AlamatOrtu { get; set; }
        public double NilaiAkhir { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
