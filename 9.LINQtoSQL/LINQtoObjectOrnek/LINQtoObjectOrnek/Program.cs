using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObjectOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = new string[] { "ADIYAMAN","AFYONKARAHİSAR","AĞRI","AKSARAY","AMASYA","ANKARA",
                "ANTALYA","ARDAHAN","ARTVİN","AYDIN","BALIKESİR","BARTIN","BATMAN","BAYBURT","BİLECİK","BİNGÖL","BİTLİS","BOLU",
                "BURDUR","BURSA","ÇANAKKALE","ÇANKIRI","ÇORUM","DENİZLİ","DİYARBAKIR","DÜZCE","EDİRNE","ELAZIĞ","ERZİNCAN",
                "ERZURUM","ESKİŞEHİR","GAZİANTEP","GİRESUN","GÜMÜŞHANE","HAKKARİ","HATAY","IĞDIR","ISPARTA","İSTANBUL","İZMİR",
                "KAHRAMANMARAŞ","KARABÜK","KARAMAN","KARS","KASTAMONU","KAYSERİ","KIRIKKALE","KIRKLARELİ","KIRŞEHİR","KİLİS",
                "KOCAELİ","KONYA","KÜTAHYA","MALATYA","MANİSA","MARDİN","MERSİN","MUĞLA","MUŞ","NEVŞEHİR ","NİĞDE","ORDU",
                "OSMANİYE","RİZE","SAKARYA","SAMSUN","SİİRT","SİNOP","SİVAS","ŞANLIURFA","ŞIRNAK","TEKİRDAĞ","TOKAT","TRABZON",
                "TUNCELİ","UŞAK","VAN","YALOVA","YOZGAT","ZONGULDAK" };

            ////1. işlem
            //foreach (string sehir in sehirler)  // baş harfi t olan şehirleri bul
            //{
            //    if (sehir.StartsWith("T"))  // if bloğu açıp şartımızı söylicez . bool tipinde değer döner
            //    {
            //        Console.WriteLine(sehir);
            //    }
            //}

            ////2. işlem-lınq TO OBJECT ile
            //var sehirlerim = from s in sehirler
            //                 where s.StartsWith("F")
            //                 select s;   // git buradaki s değerimi sehirlerim içerisine aktar
            //foreach (var sehir in sehirlerim)
            //{
            //    Console.WriteLine(sehir);
            //}

            //3.işlem - farklı varyasyonu
            //var sehirlerim = sehirler.Where(s => s.StartsWith("Y"));    // where extension bir metod ve içerisinde IEnumerable değerine sahip.yani IEnumerable değeri miraz alınmış ve buradaki arayüz miraz alındığından dolayı burada lin kullanılabilir
            //foreach (var item in sehirlerim)    // where in içerisine delegate yada başka değer yazmamak için lambda değeri kullandık..
            //    Console.WriteLine(item);          // extension metodu kullanarak lambdayla birleştirerek yeni bir işlme yaptık

            //4.işlem
            //foreach (string sehir in sehirler.Where(s=>s.EndsWith("A")))
            //{
            //    Console.WriteLine(sehir);
            //}

            //5.işlem  //lambda değeri kullanarak sıralama yap
            //foreach (string item in sehirler.OrderBy(s=>s))
            //{
            //    Console.WriteLine(item);
            //}

            //6.işlem
            //foreach (string item in sehirler.Where(s=>s.Length > 10))  //s bizim için string olarak değerlendirilir....
            //{
            //    Console.WriteLine(item + " "+ item.Length);
            //}

            //7.işlem
            //foreach (string item in sehirler.OrderByDescending(s=>s))  // tek boyutlu bir dizi o yüzden s=>s diyerek bıraktık
            //{
            //    Console.WriteLine(item);  //bunları yaparken extension metodlardan yararlanıyoruz
            //}

            //8.işlem  // ilk beş değeri yazma yani atla
            //foreach (string item in sehirler.Skip(5))
            //{
            //    Console.WriteLine(item);
            //}

            //9.işlem
            /*var a = sehirler.Take(5); */ // aşağıdaki ile aynı. uzatmamak için foreach içerisinde yapıyoruz
            //foreach (string item in sehirler.Take(5))
            //{
            //    Console.WriteLine(item);
            //}

            //10.işlem
            //Console.WriteLine(sehirler.First());

            //11.işlem
            //var sehirlerim = sehirler.Where(s => s.Length > 10);  // böyle yaparsan sadece extension metodu kullanmış olursun yani  yukarıdaki ile birebir ayı olur.ama bizim yapacağımız sql kodlara benzer kodlar yazıccaz

            //var sehirlerim = from s in sehirler   // metpdu kullanmadan sorgu ile yaptık
            //                 where s.Length > 10
            //                 select s;
            //foreach (string item in sehirlerim)
            //{
            //    Console.WriteLine(item);
            //}

            //12.işlem // iki farklı değeri kontrol et
            //var sehirlerim = from s in sehirler
            //                 where s.StartsWith("K") && s.Length > 5
            //                 select s;

            //13.işlem
            //var sehirlerim = sehirler.Where(s => s.StartsWith("K") && s.Length > 5); 
            // yani istediğiniz taktirde buradan sql komutları gibi bulunan linq komutları ile istersenizde extension metdolar ile işlemler yapabilirsiniz

            //14.işlem // linq ile sıralama
            //var sehirlerim = from s in sehirler 
            //               orderby s
            //               select s;

            //15.işlem // linq ile z den a ya sıralama
            //var sehirlerim = from s in sehirler
            //                 orderby s descending
            //                 select s;

            //16.işlem ilk 5 değeri bul
            //var sehirlerim = from s in sehirler.Skip(5)
            //                 select s;

            //17.işlem
            //var sehirlerim = from s in sehirler.Take(16) select s;


            foreach (string item in sehirlerim)
            {
                Console.WriteLine(item);
            }

            // LINQ TO OBJECT BUDUR. BUNUN SAYESİNDE İSTEDİĞİNİZ TAKTİRDE BURDAKİ EXTENSİON METODLARI KULLANRAK İŞLEM YAPABİLİR İSTEDİĞİNİZ TAKTİRDE DE BUNLARI BİR SORGU HALİNDE İFADE EDEBİLİRSİNİZ... 











            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Devam etmek için Enter'a basınız");
            Console.ReadLine();

        }
    }
}
