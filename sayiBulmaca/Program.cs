using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayı = new Random().Next(1000, 9999).ToString();

            Console.WriteLine(sayı.ToString());
            Console.WriteLine("(*) => yok\n(+) => var ve yeri de doğru\n(-) => var ama yeri yanlış");

            char[] tutulansayı = sayı.ToCharArray();


            bool durum = false;


            while (!durum)
            {
                Console.WriteLine("tahmininizi giriniz : ");

                string tahmin = Console.ReadLine();
                string sonuç = "";

                char[] tahminsayısı = tahmin.ToCharArray();

                for (int i = 0; i < tahmin.Length; i++)
                {
                    if (tutulansayı[i] == tahminsayısı[i])
                    {
                        sonuç += "+";
                    }
                    else if (sayı.Contains(tahminsayısı[i]))
                    {
                        sonuç += "-";
                    }
                    else
                    {
                        sonuç += "*";
                    }
                }

                if (sonuç == "++++")
                {
                    durum = true;
                    Console.WriteLine("Doğru");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Yanlış");
                    Console.WriteLine(sonuç + " işaretlere bakarak tekrar dene");
                }
            }
        }
    }
}
