using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commmon
{
   public static class ListExtention
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

        public static double MaxOfProperty(this SiswaMatriks siswa)
        {
            double result = 0;
            foreach(var item in siswa.GetType().GetProperties().Where(O=>O.Name!= "IdPendaftaran"))
            {
              double a=(double)  item.GetValue(siswa);
                if (a > result)
                    result = a;
            }
            return result;
        }

        public static double MinOfProperty(this SiswaMatriks siswa)
        {
            double result = 0;
            foreach (var item in siswa.GetType().GetProperties().Where(O => O.Name != "IdPendaftaran"))
            {
                double a = (double)item.GetValue(siswa);
                if (a < result)
                    result = a;
            }
            return result;
        }


    }
}
