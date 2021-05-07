using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolUzerindeHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
        tekrar:

            Console.Write("Yapmak istediğiniz işlemi giriniz : ");
            string kullanıcıgirdisi;
            kullanıcıgirdisi = Console.ReadLine();

            char[] kullanıcı_girdi = kullanıcıgirdisi.ToCharArray();

            int[,] sayi = new int[2, 10];

            Nullable<char> işlem = null;


            int a = 0;
            double sonuç = 0;
            double sayi1 = 0;
            double sayi2 = 0;


            for (int k = 0; k < 2;)
            {
                for (int i = 0; i < kullanıcı_girdi.Length && a < kullanıcı_girdi.Length; i++, a++)
                {
                    int sayaç = 0;
                    for (int j = 48; j < 58; j++)
                    {
                        if (kullanıcı_girdi[a] == j)
                        {
                            sayi[k, i] = kullanıcı_girdi[a] - 48;
                            sayaç++;
                            break;
                        }
                    }
                    if (sayaç == 0)
                    {
                        işlem = kullanıcı_girdi[a];
                        k++;
                        a++;
                        if (işlem.HasValue)
                            break;
                    }
                }
                if (a == kullanıcı_girdi.Length)
                    k++;
            }

            a = 0;
            for (int i = 9; i >= 0; i--)
            {
                if (sayi[0, i] != 0)
                {
                    sayi1 += sayi[0, i] * Math.Pow(10, a);
                    a++;
                }
            }

            a = 0;
            for (int i = 9; i >= 0; i--)
            {
                if (sayi[1, i] != 0)
                {
                    sayi2 += sayi[1, i] * Math.Pow(10, a);
                    a++;
                }
            }

            switch (işlem)
            {
                case '+':
                    { sonuç = sayi1 + sayi2; }
                    break;
                case '-':
                    { sonuç = sayi1 - sayi2; }
                    break;
                case '*':
                    { sonuç = sayi1 * sayi2; }
                    break;
                case '/':
                    {
                        sonuç = sayi1 / sayi2;
                        sonuç = Math.Round(sonuç, 2);
                    }
                    break;
                default:
                    { Console.WriteLine("geçerli bir işlem girmediniz!"); }
                    break;
            }

            Console.WriteLine("Sonuç : {0}", sonuç);

            Nullable<char> son;
            Console.WriteLine("Devam etmek için '+' ya , kapatmak için 'enter' a basın.");
            var _ = Console.ReadLine();
            if (_.Length > 0)
                son = Convert.ToChar(_);
            else
                son = 'a';

            if (son.HasValue)
            {
                if (son == '+')
                {
                    _ = new string('-', 56);
                    Console.WriteLine(_);
                    goto tekrar;
                }
            }
        }
    }
}