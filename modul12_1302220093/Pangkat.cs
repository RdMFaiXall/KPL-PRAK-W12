using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12_1302220093
{
    public class Pangkat
    {
        public static int CariNilaiPangkat(int a, int b)
        {
            // deklarasi hasilPangkat untuk menghitung pangkat
            int hasilPangkat = 1;

            // perulagan perhitungan pangkat
            for (int i = 0; i < b; i++)
            {
                // pengkondisian hasil perhitugan melebihi batas checled 
                if (hasilPangkat > int.MaxValue / a)
                {
                    return -3;
                }

                hasilPangkat = hasilPangkat * a;
            }

            // jika input b = 0
            if (b == 0)
            {
                hasilPangkat = 1;
            }
            // jika input b kurang dari 0
            if (b < 0)
            {
                hasilPangkat = -1;
            }
            // jika input b lebih dari 10 atau input a lebih dari 100
            else if (b > 10 || a > 100)
            {
                hasilPangkat = -2;
            }
            else
            {
                hasilPangkat = hasilPangkat + 0;
            }

            // mengembalikan nilai pangkat
            return hasilPangkat;
        }
    }
}
