using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAW
{
    public class Class1
    {
        public int coll = 6;
        public int row = 5;       
        double[,] NilaiAlternatif = { { 1, 3, 2, 1, 5, 3, 2 }, { 1, 2, 3, 2, 4, 2, 1 }, { 1, 1, 4, 3, 3, 1, 2 }, { 1, 2, 5, 4, 2, 3, 1 }, { 1, 3, 1, 5, 3, 2, 2 }, { 1, 1, 3, 3, 2, 1, 1 } };
        double[] bobot = { 0.25, 0.25, 0.10, 0.10, 0.10, 0.10, 0.10 };
       
        public double[,] MatriksKeputusan()
        {
             double[,] MatriksNormal = new double[coll, row];

            for (int colls = 0; colls <= coll; colls++)
            {
                for (int rows = 0; rows <= row; rows++)
                {
                    double nmax = 0;
                    for (int i = colls; i <= colls; i++)
                    {
                        for (int j = 0; j <= row; j++)
                        {
                            if (NilaiAlternatif[i, j] > nmax)
                            {
                                nmax = NilaiAlternatif[j, i];
                            }
                        }
                    }
                    MatriksNormal[colls, rows] = NilaiAlternatif[rows,colls]/nmax;
                }
            }
            return MatriksNormal;
        }

        public double[] Hasil()
        {
            double[,] MatriksN = MatriksKeputusan();
            double[] hasil = new double[coll];
            for (int i = 0; i <= row; i++)
            {

                for (int j = 0; j <= coll; j++)
                {

                    hasil[i] += bobot[i] * MatriksN[i, j]; 
                }
            }
            return hasil;
        }
    }


}
