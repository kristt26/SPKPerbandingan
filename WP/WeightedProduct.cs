using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP
{
    public class WeightedProduct
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

        public double[] NewBobot()
        {
            double n = new double();
            double[] NBobot = new double[colls];
            for (int i = 0; i <= colls - 1; i++)
            {                
                n += bobot[i];
            }

            for (int i = 0; i <= colls - 1; i++)
            {
                
                NBobot[i] = bobot[i] / n;
            }
            return NBobot;
        }

        //Vektor S
        public double[] Vector_S()
        {
            double[] NBobot = NewBobot();
            double[] VektorS = { 1, 1, 1, 1, 1, 1};
            for(int i=0;i<=rows-1;i++)
            {
                for (int j = 0; j <= colls - 1; j++)
                {                    
                    VektorS[i] *= (Math.Pow(NilaiAlternatif[i, j],NBobot[j]));
                }
            }
            return VektorS;

        }

        public double[] Vector_V()
        {
            double[] VectorS = Vector_S();
            double[] VectorV = new double[rows];
            double TotalVectorV = new double();
            for(int i=0;i<=rows-1;i++)
            {
                TotalVectorV += VectorS[i];
            }

            for (int i = 0; i <= rows - 1; i++)
            {
                VectorV[i] = VectorS[i] / TotalVectorV;
            }
            return VectorV;
        }
    }
}
