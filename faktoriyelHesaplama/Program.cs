using System;

namespace faktoriyelHesaplama
{
    class Program
    {
        public static int Faktoriyel(int f)
        {
            if (f <= 1)
                return f;
            return f *= Faktoriyel(f - 1);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Faktoriyeli alınacak sayısı giriniz: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sonuç: " + Faktoriyel(num));
            }
        }
    }
}
