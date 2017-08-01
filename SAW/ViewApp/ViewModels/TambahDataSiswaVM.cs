using Commmon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ViewApp.ViewModels
{
    class TambahDataSiswaVM:BaseSiswa,IDataErrorInfo
    {
        public CollectionView SourceView { get; set; }
        public CommandHandler ProsesCommand { get; private set; }
        public TambahDataSiswaVM()
        {

        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "IdPendaftaran")
                    return string.IsNullOrEmpty(this.IdPendaftaran) ? "Id Pendaftaran Tidak Boleh Kosong" : null;
                if (columnName == "TahunAjaran")
                    return string.IsNullOrEmpty(this.TahunAjaran) ? "Tahun Ajaran Tidak Boleh Kosong" : null;
                if (columnName == "NamaSiswa")
                    return string.IsNullOrEmpty(this.NamaSiswa) ? "Nama Siswa Tidak Boleh Kosong" : null;
                if (columnName == "TempatLahir")
                    return string.IsNullOrEmpty(this.TempatLahir) ? "Nama Siswa Tidak Boleh Kosong" : null;                
                if (columnName == "JenisKelamin")
                    return this.JK==JenisKelamin.None ? "Pilih Jenis Kelamin" : null;
                if (columnName == "NamaSiswa")
                    return this.Agama==agama.None ? "Pilih Agama" : null;
                if (columnName == "Alamat")
                    return string.IsNullOrEmpty(this.Alamat) ? "Alamat Tidak Boleh Kosong":null;
                if (columnName == "AsalSekolah")
                    return string.IsNullOrEmpty(this.AsalSekolah) ? "Alamat Tidak Boleh Kosong" : null;


                return null;
            }
        }

        public void Save()
        {

        }

        public Action WindowClose { get; set; }

        public string Error => throw new NotImplementedException();
    }
}
