using System;
using System.IO;

namespace dosyaDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string denemePath = Directory.GetCurrentDirectory() + "\\deneme.txt";
            var a = File.Create(denemePath);
            a.Close();
            StreamWriter sw = new StreamWriter(denemePath);
            
            sw.WriteLine("yemekismi");
            sw.Write("yemekismi\n");
            sw.Write(denemePath);
            
            sw.Close();
            Console.ReadKey();
            File.Delete(denemePath);
            Console.ReadKey();
        }
    }
}
