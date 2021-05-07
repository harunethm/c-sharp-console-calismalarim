using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aklindanSayiTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Random bulbakalım = new Random();
            int sayı = bulbakalım.Next(1, 100);

            bool durum = false;
            int deneme = 0;

            while (durum == false)
            {
                Console.WriteLine("tahminin : ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                deneme++;
                if (tahmin == sayı)
                {
                    Console.WriteLine("buldun");
                    Console.WriteLine(deneme + " kere denedin");
                    durum = true;
                }
                else if (tahmin > sayı)
                {
                    Console.WriteLine("azalt");
                }
                else if (tahmin < sayı)
                {
                    Console.WriteLine("arttır");
                }
            }
            Console.ReadKey();
        }
    }
}
