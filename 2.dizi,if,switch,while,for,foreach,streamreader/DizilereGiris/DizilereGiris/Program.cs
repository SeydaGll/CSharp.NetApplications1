using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilereGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 1;
            //int sayi1 = 36;
            //int sayi2 = 5;

            //int[] sayilar = new int[4];
            //sayilar[0] = 1;  // değer atama
            //sayilar[1] = 187;
            //sayilar[2] = 76;
            //sayilar[3] = 382;

            //for (int i = 0; i < sayilar.Length; i++)  // 5 elemanıda listelemek
            //    Console.WriteLine("İndex No..:" +i+ " Sayım..:"+ sayilar[i]);

            // dizilere başka bir şekilde değer atanamaz mı?

            int[] sayilar = { 12, 36, 34, 5, 6, 6789, 44 };
            for (int i = 0; i < sayilar.Length; i++)  // 5 elemanıda listelemek
                Console.WriteLine("İndex No..:" + i + " Sayım..:" + sayilar[i]);

            //string[] isimler = new string[5];
            //isimler[0] = "Ali";
            //isimler[1] = "Veli";
            //isimler[2] = "ilker";
            //isimler[3] = "hakan";
            //isimler[4] = "melis";

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("isimler..:" + isimler[i]);
            //}

            string[] isimler = { "İlker", "Hakan", "Ayse" };
            foreach (string name in isimler) // git isimler adlı dizinin içerisinden name olarak bir değeri ara ancak bunlar string bir değer olsun
            {               // aralık falan belirtmedik. git isimler dizinin içerisinde bulunan tüm string değerleri ara ve bulduğun her değeri de isim değişkenine aktar
                Console.WriteLine(name); // gezilen her isim değerini burada yazıcak

            }
            Console.WriteLine(isimler);  // tip


            // char karakteri

            string metin = "Ya Olduğun Gibi görün yada göründüğün gibi ol";
            char[] karakterler =metin.ToCharArray(); // bir string değer char ların birleştirilmesi sonucunda oluşturulan metin bütünüdür. metin değeri bir char topluluğudur
                                                      //bunu karakter bütünü olarak göstermek için tochararray adı altında bir metodu vradır. burda metin ifadesiyle bulunan string değeri git char dizisi 
                                                      //haline dönüştür dyoruz. böyle bu ifadeyi karakter kümesi haline getirmiş oluyoruz 
            Console.WriteLine(karakterler); // yanyana yazıyor.

            // alt alta yazmak istiyosan foreach kullanıyosun
            
            // değeri ters yazdırma
            Array.Reverse(karakterler);  // buraya geldiğinde terse döndürülüp karakterleri dizisi içerisinde barındırılacalk Reverse tersten sırala metodudur.
            Console.WriteLine(karakterler);
        }
    }
}
