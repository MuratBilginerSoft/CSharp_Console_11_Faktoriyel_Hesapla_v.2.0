using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Faktoriyel_Hesapla_v2._0
{
    class Program
    {
        static int fak(int x)
        {
            int carpim = 1;

            for (int i = 1; i <= x; i++)
            {
                carpim *= i;
            }
            return carpim;
        }

        static void Main(string[] args)
        {
            int x, z;
            Console.Write("Sayı Giriniz:");
            x = int.Parse(Console.ReadLine());
            z = fak(x);
            Console.WriteLine();
            Console.Write("Sonuç:");
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
