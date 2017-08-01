using Commmon;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewApp.Model.DataLayer
{
    [TableName("siswa")]
    public class DataLayerSiswa:BaseNotifyProperty
    {
        private string _IdPendaftaran;
        private string _TahunAjaran;
        private string _NamaSiswa;
        private string _TempatLahir;
        private DateTime _TanggalLahir;
        private JenisKelamin _jk;
        private agama _Agama;
        private StatusKeluarga _StatusKeluarga;
        private string _Alamat;
        private string _AsalSekolah;

        [PrimaryKey("IdPendaftaran")]
        [DbColumn("IdPendaftaran")]
        public string IdPendaftaran
        {
            get { return _IdPendaftaran; }
            set
            {
                _IdPendaftaran = value;
                OnPropertyChange("IdPendaftaran");
            }
        }

        [PrimaryKey("TahunAjaran")]
        [DbColumn("TahunAjaran")]
        public string TahunAjaran
        {
            get { return _TahunAjaran; }
            set
            {
                _TahunAjaran = value;
                OnPropertyChange("TahunAjaran");
            }
        }

        [PrimaryKey("NamaSiswa")]
        [DbColumn("NamaSiswa")]
        public string NamaSiswa
        {
            get { return _NamaSiswa; }
            set
            {
                _NamaSiswa = value;
                OnPropertyChange("NamaSiswa");
            }
        }

        [PrimaryKey("TempatLahir")]
        [DbColumn("TempatLahir")]
        public string TempatLahir
        {
            get { return _TempatLahir; }
            set
            {
                _TempatLahir = value;
                OnPropertyChange("TempatLahir");
            }
        }

        [PrimaryKey("TanggalLahir")]
        [DbColumn("TanggalLahir")]
        public DateTime TanggalLahir
        {
            get { return _TanggalLahir; }
            set
            {
                _TanggalLahir = value;
                OnPropertyChange("TanggalLahir");
            }
        }

        [PrimaryKey("JK")]
        [DbColumn("JK")]
        public JenisKelamin JK
        {
            get { return _jk; }
            set
            {
                _jk = value;
                OnPropertyChange("JK");
            }
        }

        [PrimaryKey("Agama")]
        [DbColumn("Agama")]
        public agama Agama
        {
            get { return _Agama; }
            set
            {
                _Agama = value;
                OnPropertyChange("Agama");
            }
        }

        [PrimaryKey("statusKeluarga")]
        [DbColumn("statusKeluarga")]
        public StatusKeluarga statusKeluarga
        {
            get { return _StatusKeluarga; }
            set
            {
                _StatusKeluarga = value;
                OnPropertyChange("statusKeluarga");
            }
        }

        [PrimaryKey("Alamat")]
        [DbColumn("Alamat")]
        public string Alamat
        {
            get { return _Alamat; }
            set
            {
                _Alamat = value;
                OnPropertyChange("Alamat");
            }
        }

        [PrimaryKey("AsalSekolah")]
        [DbColumn("AsalSekolah")]
        public string AsalSekolah
        {
            get { return _AsalSekolah; }
            set
            {
                _AsalSekolah= value;
                OnPropertyChange("AsalSekolah");
            }
        }
    }
}
