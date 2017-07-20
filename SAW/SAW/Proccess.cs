using Commmon;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAW
{
   public  class Proccess
    {
        public Proccess()
        {
            Siswa siswa = new Siswa();
            siswa.TeoriMatematika.Nilai = 20;
            Siswa siswa2 = new Siswa();
            siswa2.TeoriMatematika.Nilai = 72;
            DataSiswa = new List<Siswa>();

            DataSiswa.Add(siswa);
            DataSiswa.Add(siswa2);

        }

       public  List<Siswa> DataSiswa { get; set; }
    }


}
