using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkUcretiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Taksi");
            Console.WriteLine("2 - Minibus");
            Console.WriteLine("3 - Ticari araç");
            Console.Write("Araç tipini seçiniz: ");
            string araçtipi;
            araçtipi = Console.ReadLine();

            Console.Write("Kalınan saati giriniz: ");
            double süre;
            süre = Convert.ToDouble(Console.ReadLine());

            if ((süre % 10) != 0)
            {
                süre = Math.Ceiling(süre);
            }

            double ücret = 0;

            if (araçtipi == "1")
            {
                for (int i = 1; i <= süre; i++)
                {
                    if (i == 1)
                    {
                        ücret += 5;
                    }
                    else
                    {
                        ücret += ücret + (ücret * 2 / 10);
                    }
                }
                Console.WriteLine("Ücret : " + ücret);
            }
            else if (araçtipi == "2")
            {
                for (int i = 1; i <= süre; i++)
                {
                    if (i == 1)
                    {
                        ücret += 6;
                    }
                    else
                    {
                        ücret += ücret + (ücret * 215 / 1000);
                    }
                }
                Console.WriteLine("Ücret : " + ücret);
            }
            else if (araçtipi == "3")
            {
                for (int i = 1; i <= süre; i++)
                {
                    if (i == 1)
                    {
                        ücret += 6.5;
                    }
                    else
                    {
                        ücret += ücret + (ücret * 25 / 100);
                    }
                }
                Console.WriteLine("Ücret : " + ücret);
            }
            else
            {
                Console.WriteLine("Geçerli bir seçim yapmadınız.");
            }

            Console.ReadKey();
        }
    }
}
