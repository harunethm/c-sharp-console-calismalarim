using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dovizTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest baglanti_talebi = HttpWebRequest.Create("https://www.doviz.com");
            WebResponse cevap = baglanti_talebi.GetResponse();

            StreamReader cevap_oku = new StreamReader(cevap.GetResponseStream());

            string kaynak_kodlar = cevap_oku.ReadToEnd();

            double sonuç, miktar;

            int gramaltın_baslangıc_index = kaynak_kodlar.IndexOf("<span class=\"name\">GRAM ALTIN</span>") + 77;
            int gramaltın_bitis_index = kaynak_kodlar.Substring(gramaltın_baslangıc_index).IndexOf("</span>");
            double gram_altın = Convert.ToDouble(kaynak_kodlar.Substring(gramaltın_baslangıc_index, gramaltın_bitis_index));


            int dolar_baslangıc_index = kaynak_kodlar.IndexOf("<span class=\"name\">DOLAR</span>") + 72;
            int dolar_bitis_index = kaynak_kodlar.Substring(dolar_baslangıc_index).IndexOf("</span>");
            double dolar = Convert.ToDouble(kaynak_kodlar.Substring(dolar_baslangıc_index, dolar_bitis_index));

            int euro_baslangıc_index = kaynak_kodlar.IndexOf("<span class=\"name\">EURO</span>") + 71;
            int euro_bitis_index = kaynak_kodlar.Substring(euro_baslangıc_index).IndexOf("</span>");
            double euro = Convert.ToDouble(kaynak_kodlar.Substring(euro_baslangıc_index, euro_bitis_index));


            Console.WriteLine("+-----Güncel Kurlar-----+\n|1-Euro       : {0}|\n|2-Dolar      : {1}|\n|3-Gram Altın : {2}|\n+-----------------------+", euro.ToString("N6"), dolar.ToString("N6"), gram_altın);
            Console.Write("Dönüşüm yapmak istediğiniz türün numarasını giriniz : ");
            string tür = Console.ReadLine();


            switch (tür)
            {
                case "euro":
                    {
                        Console.Write("Dönüşüm yapmak istediğiniz miktarı giriniz : ");
                        miktar = Convert.ToDouble(Console.ReadLine());
                        sonuç = miktar * euro;
                        Console.WriteLine("Karşılığı : " + sonuç + " TL");
                    }
                    break;

                case "dolar":
                    {
                        Console.Write("Dönüşüm yapmak istediğiniz miktarı giriniz : ");
                        miktar = Convert.ToDouble(Console.ReadLine());
                        sonuç = miktar * dolar;
                        Console.WriteLine("Karşılığı : " + sonuç + " TL");
                    }
                    break;
                case "gram altın":
                    {
                        Console.Write("Dönüşüm yapmak istediğiniz miktarı giriniz : ");
                        miktar = Convert.ToDouble(Console.ReadLine());
                        sonuç = miktar * gram_altın;
                        Console.WriteLine("Karşılığı : " + sonuç + " TL");
                    }
                    break;

                default:
                    Console.WriteLine("Geçerli bir tür girmediniz!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
