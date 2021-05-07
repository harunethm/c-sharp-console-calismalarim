using System;
using System.IO;

namespace dosyaIslemleriDeneme
{
    class Program
    {
        public static string textOku(string dosyaYolu)
        {
            FileStream fs;
            StreamReader sr;
            try
            {
                fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
            }
            catch (Exception)
            {
                Console.WriteLine("Dosya Yolu Yanlış !!!");
                throw;
            }
            
            string okunan = sr.ReadToEnd();
            
            sr.Close();
            fs.Close();
            
            return okunan;
        }


        public static void textYaz(string yazilacak)
        {
            //FileStream fs = new FileStream(@"C:\Users\canha\OneDrive\Masaüstü\New Folder\Yeni Metin Belgesi.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            StreamWriter sw = File.AppendText(@"New Folder\Yeni Metin Belgesi.txt");

            sw.Write(yazilacak+ "\n");

            sw.Close();
            //fs.Close();

            Console.WriteLine("Dosyaya başarıyla yazıldı ...");
        }

        public static void createDirectory(string dosyaYolu)
        {
            FileStream fs = null;
            if (!File.Exists(dosyaYolu))
                fs = new FileStream(dosyaYolu, FileMode.Create);

            Console.WriteLine("Dosya başarıyla oluşturuldu ...");
            fs.Close();
        }

        static void Main(string[] args)
        {
            //Directory.CreateDirectory("New Folder");
            //Directory.CreateDirectory(@"C:\Users\canha\OneDrive\Masaüstü\New Folder");
            
            //Directory.GetCreationTime(@"C:\Users\canha\OneDrive\Masaüstü\New Folder");
            //Directory.GetLastAccessTime(@"C:\Users\canha\OneDrive\Masaüstü\New Folder");
            //Directory.GetLastWriteTime(@"C:\Users\canha\OneDrive\Masaüstü\New Folder");

            //Directory.Move("New Folder", @"C:\Users\canha\OneDrive\Masaüstü\Yeni Klasör");
            //bool a = Directory.Exists(@"C:\Users\canha\OneDrive\Masaüstü\New Folder");
            //if (a)
            //    Console.WriteLine("yeap");

            string komut = "";
            while (true)
            {
                Console.WriteLine("Komutları görmek için 'help' yazın.");
                komut = Console.ReadLine();

                switch (komut)
                {
                     case "help":Console.WriteLine("yaz , oku ,  dosya_ac, exit");
                        break;
                    case "yaz":Console.Write("Metni giriniz:");
                        Program.textYaz(Console.ReadLine());
                        break;
                    case "oku":Console.WriteLine("okumak istediğiniz dosya yolunu giriniz : ");
                        Console.WriteLine(Program.textOku(Console.ReadLine()).ToString());
                        break;
                    case "exit":Environment.Exit(1);
                        break;
                    case "dosya_ac":createDirectory(Console.ReadLine());
                        break;
                    /*
                    case "":
                        break;
                    case "":
                        break;*/
                    default:
                        break;
                }
            }

        }
    }
}
