using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulmaca2
{
    class Program
    {
        static void Main(string[] args)
        {
        enbas:
            Console.WriteLine("Kaç basamaklı bir sayı tutayım?(1-8 arasında)");
            int basamak = (int)Convert.ToDouble(Console.ReadLine());
            if (basamak > 8)
            {
                Console.WriteLine("1 ile 8 arasında dedik ya yav :D");
                goto enbas;
            }
            else if (basamak == 0)
            {
                Console.WriteLine("Sıfır basamaklı sayı mı, bulursan haber et de biz de bilelim :D");
                goto enbas;
            }
            else if (basamak < 0)
            {
                Console.WriteLine("Sıfırdan daha düşük basamak yok malesef :(");
                goto enbas;
            }

            double AltSinir = Math.Pow(10, basamak - 1) - 1;
            double UstSinir = Math.Pow(10, basamak);

            string sayı = new Random().Next((int)AltSinir, (int)UstSinir).ToString();
            Console.WriteLine(sayı.ToString());

            bool durum = false;
            while (!durum)
            {
            büyükse:
                Console.Write("tahmininizi giriniz : ");
                string tahmin = Console.ReadLine();
                if (tahmin.Length > sayı.Length)
                {
                    Console.WriteLine("girdiğiniz sayı çok büyük");
                    goto büyükse;
                }
                string sonuç = "";
                for (int i = 0; i < tahmin.Length; i++)
                {
                    if (sayı[i] == tahmin[i])
                        sonuç += "+";
                    else if (sayı.Contains(tahmin[i]))
                        sonuç += "-";
                    else
                        sonuç += "*";
                }
                if (sonuç == new String('+', basamak))
                {
                    Console.WriteLine("Doğru");
                    durum = true;
                    Console.ReadLine();
                }
                else
                    Console.WriteLine("Yanlış\n" + sonuç + " işaretlere bakarak tekrar dene");
            }
        }
    }
}
