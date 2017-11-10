using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOrnek
{
    class Program
    {
        public delegate bool Diziİslemleri(string s); // şimdide bunun metodunu yazalım

        public static string[] IslemMetot(string[] dizi, Diziİslemleri fonksiyon)
        {
            ArrayList arr = new ArrayList();
            foreach (string item in dizi)
            {
                if (fonksiyon(item))
                {
                    arr.Add(item);
                }
            }

            return (string[])arr.ToArray(typeof(string)); // ** cast işlemi yapıyoruz. çünk benim elimde ArrayList var ve bana string dizisi lazım.typepf ile bunun string olarak her değerini gör ve bu gördüğün değerleri bir diziyap ve daha sonra bunu cast et.. 

        }  // şimdi git bunu kullan ( main de)



        static void Main(string[] args)
        {
            // Lambda => .. LINQ içerisinde sıklıkla kullanılır..bunun bazı delegeler yardımıyla nasıl kullanıcağına bakıcaz..
            string[] sehirler = { "Ankara", "Adıyaman", "Konya", "Kayseri", "Ağrı", "Kırşehir", "İzmir" };

            //işlem 1
            Diziİslemleri islem = delegate (string s) { return s.StartsWith("İ"); };  //islem in içerisinde i ile başlayan şehirlerin değerleri var..
            string[] stri = IslemMetot(sehirler, islem);

            //işlem2
            string[] strA = IslemMetot(sehirler, delegate (string s) { return s.StartsWith("A");});


            //İŞLEM3
            string[] strR = IslemMetot(sehirler, (r => r.EndsWith("r")));  



            Console.WriteLine("İ ile başlayanlar");
            foreach (string item in stri)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A ile başlayanlar");
            foreach (string item in strA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("R ile bitenler");
            foreach (string item in strR)
            {

                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
