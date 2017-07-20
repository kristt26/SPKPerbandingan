using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPSIS
{
    public class TopsisLib
    {
        public int colls = 7;
        public int rows = 6;
        double[,] NilaiAlternatif = {
                { 1, 3, 2, 1, 5, 3, 2 },
                { 1, 2, 3, 2, 4, 2, 1 },
                { 1, 1, 4, 3, 3, 1, 2 },
                { 1, 2, 5, 4, 2, 3, 1 },
                { 1, 3, 1, 5, 3, 2, 2 },
                { 1, 1, 3, 3, 2, 1, 1 }
        };
        double[] bobot = { 0.25, 0.25, 0.1, 0.1, 0.1, 0.1, 0.1 };
        public double[,] Matriks_Normal()
        {
            double[,] MatriksNormal = new double[rows,colls];
            for (int coll = 0; coll <= colls - 1; coll++)
            {                
                double[] datax = new double[rows];
                for (int row = 0; row <= rows - 1; row++)
                {
                    datax[row] = NilaiAlternatif[row, coll];
                }
                double X = Nilai_X(datax);
                for (int row = 0; row <= rows - 1; row++)
                {
                    MatriksNormal[row, coll] = NilaiAlternatif[row, coll] / X;
                }
            }
            return MatriksNormal;

        }

        public double[,] Matriks_Y()
        {
            double[,] MatriksY = new double[rows, colls];
            double[,] MatriksNormal = Matriks_Normal();

            for(int i=0;i<=rows-1;i++)
            {
                for(int j=0;j<=colls-1;j++)
                {
                    MatriksY[i, j] = bobot[j] * MatriksNormal[i, j];
                }
            }
            return MatriksY;

        }

        public double[] SolusiIdealPositif ()
        {
            double[] NilaiPositif = new double[colls];
            double[,] MatriksY = Matriks_Y();
            for (int coll = 0; coll <= colls - 1; coll++)
            {
                double[] datax = new double[rows];
                for (int row = 0; row <= rows - 1; row++)
                {
                    datax[row] = MatriksY[row, coll];
                }
                NilaiPositif[coll] = datax.Max();                
            }
            return NilaiPositif;
        }

        public double[] SolusiIdealNegatif()
        {
            double[] NilaiNegatif = new double[colls];
            double[,] MatriksY = Matriks_Y();
            for (int coll = 0; coll <= colls - 1; coll++)
            {
                double[] datax = new double[rows];
                for (int row = 0; row <= rows - 1; row++)
                {
                    datax[row] = MatriksY[row, coll];
                }
                NilaiNegatif[coll] = datax.Min();
            }
            return NilaiNegatif;
        }

        public double[] JarakNilaiIdealPositif()
        {
            double[,] MatriksY = Matriks_Y();
            double[] NilaiPositif = SolusiIdealPositif();
            double[] JarakNilaiPositif = new double[rows];
            for (int i=0;i<=rows-1;i++)
            {
                double B = new double();
                for(int j=0;j<=colls-1;j++)
                {
                    B += (Math.Pow((MatriksY[i, j] - NilaiPositif[j]), 2));
                }                
                JarakNilaiPositif[i]= Math.Sqrt(B);
            }
            return JarakNilaiPositif;
        }

        public double[] JarakNilaiIdealNegatif()
        {
            double[,] MatriksY = Matriks_Y();
            double[] NilaiNegatif = SolusiIdealNegatif();
            double[] JarakNilaiNegatif = new double[rows];
            for (int i = 0; i <= rows - 1; i++)
            {
                double B = new double();
                for (int j = 0; j <= colls - 1; j++)
                {
                    B += (Math.Pow((MatriksY[i, j] - NilaiNegatif[j]), 2));
                }
                JarakNilaiNegatif[i] = Math.Sqrt(B);
            }
            return JarakNilaiNegatif;
        }

        public double[] AlternatifSolusi()
        {
            double[] JarakNilaiNegatif = JarakNilaiIdealNegatif();
            double[] JarakNilaiPositif = JarakNilaiIdealPositif();
            double[] NilaiAlternatif = new double[rows];
            for(int i =0;i<=rows-1;i++)
            {
                NilaiAlternatif[i] = JarakNilaiNegatif[i] / (JarakNilaiPositif[i] + JarakNilaiNegatif[i]);
            }
            return NilaiAlternatif;
        }

        public double Nilai_X(double[] data)
        {
            double awal = new double();
            foreach (var item in data)
            {
                awal += (Math.Pow(item, 2));
            }
            double Nx = Math.Sqrt(awal);
            return Nx;
        }
    }
}
