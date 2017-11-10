using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Keywordü nedir ? 
            /* variable ın kısaltılmışıdır.. Genellikle LINQ ile kullanılır. 
             * tüm değişkenlere eşlik edebilcek bir veri tipidir. eğer var ın içerisine bir int aktarılacaksa bu nt olarak değerlendirilir.
             * tüm veri tiplerinin içerisinde kullanılır. genellikle linq ile....
             * Bunun  veri tiplerini görmek için GetType() metodunu kullanıcaz..bu şekilde variable ların veri tiplerinin ne şekilde ifade edildiğini görmüş olucaz..*/

            var islem1 = 36.63;
            Console.WriteLine("Birinci Değişken Tipi....:  {0}",islem1.GetType()); // gettype verini tipini gösterir

            var islem2 = "Merhaba";
            Console.WriteLine("İkinci Değişken Tipi....:  {0}", islem2.GetType()); // gettype verini tipini gösterir

            //islem2. // islem2 bir string olmasına rağmen . bastığımızda içerisinde string metodları çıkmadı.çünkü variable ın içerisinde ne olduğunu bu şuan için anlamaz. 
            // ve bize bunun ne olduğunu göstermez.sadece derleme sırasında bunu açığa çıkartır ve bizim kullanımımıza sunar ve bunu bilmemi için 

            var islem3 = islem2;
            Console.WriteLine("İkinci Değişken Tipi....:  {0}", islem3.GetType()); // gettype verini tipini gösterir
            DenemeMetot();
            

            Console.WriteLine();
            Console.WriteLine("Devam etmek için enter a basınız");
            Console.ReadLine();
        }

        public  int sayi = 147;
        //var islem4 = 363;  // bu  hata verir.!! var keyword leri metodların, proppery lerin gibi bazı değerlerin içerisinde tanımlanabilir. burda tanımlanamaz. yani direkt 
        // olarak bir class ın içerisinde kullanılamaz..bundan dolayı global bir veri değerinin buradan tanımlanamadığını söyleyebilriz...


        //işlem5
        // var değişkeni local olarak tanımlanmalıdır. ve önceden tanımlanmlıdır..
        //public void Deneme(var islemDegeri)  // hatalıdır
        //{
        //    islemDegeri.  
        //}

        //public var Deneme()  // böyle kullanılamaz...variable ler geriye veri tipi döndürmek için kullanılmaz...
        //{
        //    var islem6 = 123;
        //    return islem6;
        //}


        static public void DenemeMetot()
        {
            var islem7 = "İlker";
            Console.WriteLine("yedinci Değişken Tipi....:  {0}", islem7.GetType()); // gettype verini tipini gösterir

            //var islem8 = null;  //varable lar null olarak nitelendirilemez. null değer alamaz...
            // null boş bir değer demektir...null yer kaplamaz. boşluk değeri demektir.. islem8 = "" bu ramde yer kaplar. null ile aynı değildir..
            Console.WriteLine();

            // var ın en  çok kullanıldığı alan
            Console.WriteLine("LINQ Sorgusu");

            Console.WriteLine("Baş harfi K ile başlayan şehirler");
            string[] sehirler = new string[] { "Konya", "Ankara", "Kastamonu", "Gaziantep", "İstanbul","Kırşehir" };
            var sorgu = from s in sehirler
                        where s.StartsWith("K")
                        select s;

            // bu listenin içerisindeki verileri görebilmem için foreach döngüsü kuruyorum
            foreach (var sehir in sorgu) 
            {
                Console.WriteLine("K harfi  ==>"+ sehir);  // sehir olarak gezdiğin değerleri getir ve yazdır
            }



                
        }




    }
}
