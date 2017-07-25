using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
    public class NilaiAlternatif_Matriks
    {
        public List<SiswaMatriks> MatriksKeputusan()
        {
            var DatasMatriks = new List<SiswaMatriks>();

            foreach (var siswa in CriteriasCollection.DataSiswa())
            {
                var a = new SiswaMatriks { Kelengkapan = siswa.Kelengkapan.Rank, IdPendaftaran = siswa.IdPendaftaran, Keahlian = siswa.Keahliah.Rank, NilaiBahasaIndonesia = siswa.BahasaIndonesia.Rank, NilaiBahasaInggris = siswa.BahasaInggris.Rank, NilaiMatematika = siswa.Matematika.Rank, NilaiWawancara = siswa.HasilWawancara.Rank, NilaiKesehatan = siswa.HasilKesehatan.Rank };
                DatasMatriks.Add(a);
            }
            return DatasMatriks;
        }
    }
}
