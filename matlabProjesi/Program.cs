using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matlabProjesi
{
    class Program
    {
        public static double f(double x)
        {
            // fonksiyon buraya yazılır
            double _ = 4 * Math.Pow(x, 3) - 5 * Math.Pow(x, 2) + x - 1;
            return _;
        }
        public static double f_turev_1(double x)
        {
            double _ = (12 * Math.Pow(x, 2)) - (10 * x) + 1;
            return _;
        }

        public static double f_turev_2(double x)
        {
            double _ = (24 * x) - 10;
            return _;
        }

        public static double f_turev_3(double x)
        {
            double _ = 24;
            return _;
        }

        public static double turev_1(double x, double h)
        {
            double _ = (Math.Round(f(x + h), 4) - Math.Round(f(x - h), 4)) / (2 * h);
            return _;
        }

        public static double turev_2(double x, double h)
        {
            double _ = (Math.Round(f(x + h), 4) + Math.Round(f(x - h), 4) - (Math.Round(f(x),4) * 2)) / Math.Pow(h , 2);
            return _;
        }

        public static double turev_3(double x, double h)
        {
            double _ = ((-2 * Math.Round(f(x + h), 4)) + (2 * Math.Round(f(x - h), 4)) + Math.Round(f(x + (2 * h)), 4) - Math.Round(f(x -(2 * h)), 4)) / (2 * Math.Pow(h, 3));
            return _;
        }

        public static double richardsonMethod(double h, double h_2)
        {
            double _ = h_2 + ((h_2 - h) / 3);
            return _;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            int x_index = rnd.Next(20);
            double h = 0.25;

            // h değeri için
            double yaklasikDeger_h;
            // h/2 değeri için
            double yaklasikDeger_h_2;
            // gerçek degere en yakın sayı
            double gercekDeger;

            //x ve y değerlerini tutan dizi
            double[,] _dizi = new double[20, 2];

            //20 tane x değeri (h=0.25 için) ataması
            for (double i = 0, j = 1; i < _dizi.Length / 2; i++, j += 0.25)
            {
                _dizi[(int)i, 0] = j;
            }

            Console.WriteLine("x değeri : " + _dizi[x_index, 0]);
            Console.WriteLine("h değeri : " + h);
            Console.WriteLine("h/2 değeri : " + h / 2);

            yaklasikDeger_h = turev_1(_dizi[x_index, 0], h);
            yaklasikDeger_h_2 = turev_1(_dizi[x_index, 0], h/2);

            gercekDeger = richardsonMethod(yaklasikDeger_h, yaklasikDeger_h_2);
            Console.WriteLine("Geçek değer : " + f_turev_1(_dizi[x_index, 0]));
            Console.WriteLine("1. türev için gerçeğe en yakın değer : " + gercekDeger);

            yaklasikDeger_h = turev_2(_dizi[x_index, 0], h);
            yaklasikDeger_h_2 = turev_2(_dizi[x_index, 0], h/2);

            gercekDeger = richardsonMethod(yaklasikDeger_h, yaklasikDeger_h_2);
            Console.WriteLine("Geçek değer : " + f_turev_2(_dizi[x_index, 0]));
            Console.WriteLine("2. türev için gerçeğe en yakın değer : " + gercekDeger);

            yaklasikDeger_h = turev_3(_dizi[x_index, 0], h);
            yaklasikDeger_h_2 = turev_3(_dizi[x_index, 0], h/2);

            gercekDeger = richardsonMethod(yaklasikDeger_h, yaklasikDeger_h_2);
            Console.WriteLine("Geçek değer : " + f_turev_3(_dizi[x_index, 0]));
            Console.WriteLine("3. türev için gerçeğe en yakın değer : " + gercekDeger);


            Console.ReadLine();

        }
    }
}
