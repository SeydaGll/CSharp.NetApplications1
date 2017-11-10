
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectveCollectionDegerAtama  // 5. ödev den başladı
{
    class Program  //8 tane varyasyonun ne şekilde gerçekleştiğini görmeye çalışacağız
    {
        static void Main(string[] args)
        {
            //-----1. Standart olarak yeni örnekler üretip değer atama işlemi.. ( bunun için yeni bir senaryo uydurarak aşağıda classlar tanımlayalım)
            Satis satis1 = new Satis();  // default cotr yi kullandım.yani burada varsayılan cotr kullanılmış oldu
            satis1.SatisID = 178;
            satis1.SatisTarihi = DateTime.Parse("01/01/2011 2:29AM");   // SatisTarihi içerisine datatime tipinden bir değer aldığından dolayı bunu convert etmemiz gerekir.  veya bunu Parse yöntemi ile işleme tabi tutabilirlir
            //   satis1.SatisTarihi  // BÖYLE yazarak bu değeri okuyabilirim


            //----2.Consstructor Overloaded kullanarak Yeni bir örnek tanımlamak
            Satis satis2 = new Satis(178, Convert.ToDateTime("02/02/2011 03:30AM"));
            //    satis2.SatisTarihi  // BU ŞEKilde yazarak artık bu değeri okuyabilirim.sadece yukarıdaki ile aktarma yönleri farklı

            //----3. Dizilere Değerleri Direk olarak Atama işlemleri( yani bir dizi tanımlayıp daha sonra bunun içerisine bir add metodu ile veya indis numarasını vererek bir değer aktarmak yerine direk değer atama işlemlerine bakıcaz )
            //int[] sayilar = new int[20];
            //sayilar[0]=..  // BÖYLE YAPMAK YERİNE

            int[] sayilar = { 30, 36, 254, 321 };
            string[] sehirler = { "Konya", "Karaman", "Ankara" };  // BU ŞEKİlde yaparak bunun boyutlarını belirmeme gerek kalmıyor.içerisine şu kadar giricem diye değer belirtmek zorunda değilsin
                                                                   // bunu yapmamızı sağlayan küme parantezleridir!

            //---4. Varsayılan constructor  ile değer implement etmek : 
            // implicity bir değer atama işlemi
            Satis satis3 = new Satis { SatisID = 123, SatisTarihi = DateTime.Now, MusteriAdi = "İlker", SatisTutari = 305, };
            // bu şekilde bir cotr atayarakta değer atama işlemine gidebiliriz. tüm değerleri yazmanada gerek yok. GÜVENLİ bir işlemdir..yani implicity olarak değerlendirilir
            //satis3.SatisTutari =  // diyerek bunlarn get özelliklerini kullanrak bunları okuyabiliriz
            Console.WriteLine("Satis3 ==>" + satis3.SatisTarihi + "- " + satis3.MusteriAdi);

            //---5.Varsayılan constructor  ile değer implement etmek
            //explicitly bir değer atama işlemi
            Satis satis4 = new Satis() { SatisID = 159, MusteriAdi = "Ahmet", SatisTarihi = DateTime.Now, SatisTutari = 258.56M }; // BU ŞEKİLDE de tanımlanabilir
            Console.WriteLine("Satis4==>" + satis4.MusteriAdi + " " + satis4.SatisTutari);

            //---6. İç İÇe Nesneleri Eklemek
            Satis satis5 = new Satis()
            {
                IsAdresi = new Adres { Il = "KONYA", Ilçe = "selçuklu", PostaKodu = "4200", Adres1 = "yazır mah." },
                EvAdresi = new Adres { Il = "Konya", Ilçe = "karatay", PostaKodu = "42030", Adres1 = "gaziosmanpaşa mah." }
                
                
            };
            Console.WriteLine("Satis5==>" + satis5.EvAdresi.Adres1 + " " + satis5.EvAdresi.Ilçe);
            Console.WriteLine("Satis5==>" + satis5.IsAdresi.Adres1 + " " + satis5.IsAdresi.Ilçe);

            //---7. Toplu olarak veri ekleme işlemleri:  yani bir koleksiyon değerine veriler nasıl direkt olarak eklenr
            //ICollection<T> içerisine değer atama
            Satis satis6 = new Satis() {
                Urunler = new List<Urun>
                {
                    new Urun { UrunID=12, UrunAdi="Elma", Kalite=1}, // 0. indis
                    new Urun{ UrunID=195, UrunAdi="Armut", Kalite=3}, //1.indis
                    new Urun{ UrunID=357, UrunAdi="Kiraz", Kalite=2} //2.indis
                }
            };
            //yani satı6 ya yeni ürünler girebilmem için ürünler adı altında bulunan property içerisine yeni değerler eklnedi. bu yeni değerlerin eklenmesi için bir listeye ihtiyacım var.ve bu liste elimde olmadığı için yeni bir liste oluşturmam gerkir.new ile yeni bir liste oluşturdum. 
            // bunun içerisine 3 değer girdim. yani bunların item olarak değerlendirilen yeni değerler olduğunu söyleyebilriz.
            Console.WriteLine("Satis6==>" + satis6.Urunler[0].UrunID + " " + satis6.Urunler[0].UrunAdi);

            //---8. IEnumerable değer ekleme işlemleri
            List<int> yeniSayilar = new List<int> { 20, 35, 54, 3456, 234, 3 }; // buşekilde sayı değerlerini direk olarak girebilriz.
                                                                                // bunu sağlayan işlem bizim için direk olrak koleksiyonları bir object miş gibi içeriye vermektir.

            ArrayList satisListesi = new ArrayList { satis1, satis2, satis3, satis4, satis5, satis6 }; // bu şekilde tüm satışları bu şkilde bir satış listesine verebilriz
                                                                                                       // ve daha sonra bunu foreach döngüsüyle dönerek tüm değerlerini görebilriz
                                                                                                     

            foreach (Satis item in satisListesi)  // buradaki satışlar bir Satis class ı tipinden olduğundan dolayı bunun içerisinde Satis tipinden gezebilriz
            {
                //item.  // item ın içerisinde bulunan değerler sizin için satis in içerisinde bulunan değerlerdir...bunların içerisini tam manasıyla doldurark buradak değerleri okuyabilirsiniz..
            }

            





            Console.ReadLine();



        }
    }

    class Satis
    {
        public int SatisID { get; set; }
        public DateTime SatisTarihi { get; set; }
        public string MusteriAdi { get; set; }
        public decimal SatisTutari { get; set; }
        public List<Urun> Urunler { get; set; }
        public Adres IsAdresi { get; set; }
        public Adres EvAdresi { get; set; }



        public Satis()
        {

        }

        public Satis(int satisID, DateTime satisTarihi )
        {
            SatisID = satisID; // prop içerisine dışardan geleni ver
            SatisTarihi = satisTarihi;
        }

    }

    class Urun
    {   
        public int UrunID { get; set; }  // tablo gibi düşün
        public string UrunAdi { get; set; }
        public int Kalite { get; set; }

    }

    class Adres
    {
        public string Adres1 { get; set; }
        public string Il { get; set; }
        public string Ilçe { get; set; }
        public string PostaKodu { get; set; }

    }
}
