using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBolum1//  delegate : temsilci
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Konya", "Ankara", "Antalya", "KahramanMaraş", "Kırşehir", "Kastamonu", "Ağrı" };

            ////Bölüm 1
            //List<string> stringA = new List<string>();

            //foreach (string item in sehirler)
            //{
            //    if (item.StartsWith("A")) // startwith bool değer gönderir
            //    {
            //        stringA.Add(item);
            //    }
            //}


            //foreach (string item in stringA)
            //{
            //    Console.WriteLine("şehir değeri...:"+item);
            //}


            //Bölüm2
            Console.WriteLine("Seçiniz.. 1(Başlangıç Harfi), 2(Bitiş Harfi)");
            string secenek = Console.ReadLine();
            Console.WriteLine("Harf Giriniz..");
            string metin = Console.ReadLine();

            List<string> a = new List<string>();
            if (secenek == "1")
            {
                a= BaslangicHarfiIleDegerlendir(sehirler,metin);
            }
            else if (secenek == "2")
            {
                a = BitisHarfiIleDegerlendir(sehirler, metin);
            }

            foreach (string item in a)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

        }


        static List<string> BaslangicHarfiIleDegerlendir(string[] dizi, string baslangicHarf)
        {
            List<string> a = new List<string>();
            foreach (string item in dizi)
            {
                if (item.StartsWith(baslangicHarf))
                {
                    a.Add(item);
                }
            }
            return a;  //eğer buna uygun durum yok ise bu null dönecektir
        }

        static List<string> BitisHarfiIleDegerlendir(string[] dizi, string bitisHarfi)
        {
            List<string> a = new List<string>();
            foreach (string item in dizi)
            {
                if (item.EndsWith(bitisHarfi))
                {
                    a.Add(item);

                }
            }
            return a;  // return olarak a listini gönderir..
        }
        
    }
}
// eğer delegate kullansaydık bu metodları bu şekilde kullanmak zorunda kalmıcaktık. çünkü bu metodlar bizim içn delegate in imzalanmış olduğu ve delegate in göndermiş olduğu metodlar olucak
// ve bundan dolayı kriter e uygun olarak sadece bir çatı altında tablamış olucaktık
