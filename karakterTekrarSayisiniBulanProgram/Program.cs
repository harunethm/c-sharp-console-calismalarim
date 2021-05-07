using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karakterTekrarSayisiniBulanProgram
{
    class Program
    {
        static void yontem_1()
        {
            Console.WriteLine("metni giriniz: ");
            string girdi = Console.ReadLine();
            char[] metin = girdi.ToCharArray();

            char[] çıkmışlar = new char[girdi.Length];
            int[] adet = new int[girdi.Length];

            int iç = 0;

            for (int i = 0; i < girdi.Length; i++)
            {
                adet[i] = 0;

                if (!çıkmışlar.Contains(metin[i]))
                {
                    çıkmışlar[iç] = metin[i];
                    iç++;

                    for (int j = 0; j < girdi.Length; j++)
                    {
                        if (metin[i] == metin[j])
                        {
                            adet[i] += 1;
                        }
                    }

                    Console.WriteLine(çıkmışlar[iç - 1] + " karakteri " + adet[i] + " adet bulunuyor.");
                }
            }
            Console.ReadKey();
        }
        static void yontem_2()
        {
            Console.WriteLine("metni giriniz: ");
            String metin = Console.ReadLine();
            char[] cikanlar = new char[metin.Length];
            int[] adet = new int[metin.Length];
            int sayac = -1;
            foreach (char i in metin)
            {
                if (!cikanlar.Contains(i))
                {
                    sayac++;
                    cikanlar[sayac] = i;
                    adet[sayac] = 1;
                }
                else
                {
                    adet[sayac]++;
                }
            }

            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine(cikanlar[i] + " - " + adet[i]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            yontem_1();
            //yontem_2();
        }
    }
}
