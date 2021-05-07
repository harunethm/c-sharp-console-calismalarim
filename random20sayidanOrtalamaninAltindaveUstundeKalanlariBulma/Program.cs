using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random20sayidanOrtalamaninAltindaveUstundeKalanlariBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random sayı = new Random();

            for (int i = 0; i < 20; i++)
            {
                dizi[i] = sayı.Next(100);
                Console.WriteLine(dizi[i]);
            }

            int ort = 0;

            for (int i = 0; i < 20; i++)
            {
                ort += dizi[i];
            }

            ort = ort / 20;

            int büyüksayısı = 0;
            int küçüksayısı = 0;

            for (int i = 0; i < 20; i++)
            {
                if (dizi[i] >= ort)
                {
                    büyüksayısı++;
                }
                else
                {
                    küçüksayısı++;
                }
            }
            Console.WriteLine("ortalamanın üstünde " + büyüksayısı + " not var.");
            Console.WriteLine("ortalamanın altında " + küçüksayısı + " not var.");

            Console.ReadKey();
        }
    }
}
