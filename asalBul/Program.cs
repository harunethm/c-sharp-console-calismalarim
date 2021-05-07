using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalBul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sayıyı giriniz: ");
            double asalbul = Convert.ToDouble(Console.ReadLine());

            int sayaç = 0, asalsayısı = 0;

            int[] asal = new int[5];

            for (int i = 2; i < asalbul / 2; i++)
            {
                if (asalbul % i != 0)
                    sayaç++;
                else
                {
                    sayaç = 0;
                    Console.WriteLine("sayı asal değildir.");
                    goto son;
                }
            }
            Console.WriteLine(asalbul);

            for (int j = 0; j < 5;)
            {
                for (int i = 2; i < asalbul / 2; i++)
                {
                    if (asalbul % i != 0)
                        sayaç++;
                    else
                    {
                        sayaç = 0;
                        break;
                    }
                }

                if (sayaç + 1 == Math.Floor(asalbul / 2))
                {
                    asal[j] = Convert.ToInt32(asalbul);
                    sayaç = 0;
                    j++;
                }
                asalbul++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(asal[i]);
            }

        son:
            Console.ReadKey();
        }
    }
}
