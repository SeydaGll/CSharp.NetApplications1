using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // anonim tipler nedir ve nasıl tespit edilir?
            int a = 1;  // bunun geldiği yer systrem in içerisinde bulunan int32 olarak değerlendirilir. system.ınt32 yani struct tır. vs bunları taır.
            Console.WriteLine("a Veri Tipi....:{0}", a.GetType());


            Satis satis1 = new Satis() { SatisID=123, SatisTarihi=DateTime.Parse("02/02/2010 02:20AM"), SatisTutari=300.52M};  // bu aslında bir değişken tanımlamadır. satış ifadesiyle bulunan bir değişken tanımlanmıştırç.c# bunu bir veri tipi olarak görmez
            Console.WriteLine("Satis1 Veri Tipi....:{0}",satis1.GetType()); //AnonimTipler.Satis ( satis1değişkeninin veri tipi Satis dir )  yani Satis bir veri tipidir. yani bana ait bir veri tipdir..


            var satis2 = new Satis { SatisID = 124, SatisTarihi = DateTime.Parse("02/02/2010 02:20AM"), SatisTutari = 123.65M, };
            Console.WriteLine("Satis2 Veri Tipi....:{0}", satis2.GetType());

            var satis3 = new { ID = 125, Tutar = 365.45M, };  // herhangi bir sınıf yada veri tip yazmadım. benim için variable ın içerisine yenib ir değer eklemem gerektiğini söylüyorum. yani benim buraya yazmış olduğum değerler yeni tanımlanıyorolan değerlerdir..en üst katmanda yeni bir değer tanımlmam için benim için blok açıyor.. BUNU Artık c# tanıyor. yai satis3 ün içerisine ID,Tutar değeri var.
            Console.WriteLine("Satis3 Veri Tipi....:{0}", satis3.GetType()); //:<>f__AnonymousType0`2[System.Int32,System.Decimal]

            //bu işlemleri linq içerisinde sıklıkla görücez..

            var satis4 = new { ID = 126, SatisTutari = 123.87M, YeniOzellik = "ilker" };
            Console.WriteLine("Satis4 Veri Tipi....:{0}", satis4.GetType());  //<>f__AnonymousType1`3[System.Int32,System.Decimal,System.String]

            var satis5 = new { ID = 127, YeniOzellik = "ABC", SatisTutari = 159.91M, Durum = true };  // bu şekilde kendine veri tipi oluşturabilirsin
            Console.WriteLine("Satis5 Veri Tipi....:{0}", satis5.GetType());

            var satis6 = new { isim="ilker", soyad="ışık" };
            Console.WriteLine("Sati6 Veri Tipi....:{0}", satis6.GetType());

            Satis satis8 = new Satis { MusteriAdi = "ilker" };
            var satis7 = new { ID = 1, satis8 };
            Console.WriteLine("Satis7 Veri Tipi....:{0}", satis7.GetType());

            List<Satis> satisListesi = SatisListesiHazirla();

            var benimSatisim = from o in satisListesi
                               select new
                               {
                                   ID = o.SatisID,
                                   Tutar = o.Urunler.Sum(p => p.Miktar),
                                   Tarih = o.SatisTarihi
                               };

            Console.WriteLine("benimSatisim Veri Tipi....:{0}", benimSatisim.GetType());


            foreach (var kisi in benimSatisim)
            {
                Console.WriteLine("        Satış ID...:{0}   Miktar...:{1}    Tarih..:{2}",kisi.ID, kisi.Tutar, kisi.Tarih);
            }

            Console.ReadLine();



        }

        // satış tablosu ve ürün tablosu hazırlamak
        static private List<Satis> SatisListesiHazirla()
        {

            List<Satis> satisListesi = new List<Satis>();

            Satis s1 = new Satis();
            s1.SatisTarihi = DateTime.Parse("01/01/2011 9:25AM");
            s1.SatisID = 1001;

            Urun u1 = new Urun();
            u1.UrunID = 300;
            u1.UrunAdi = "Elma";
            u1.Miktar = 20;
            s1.Urunler.Add(u1);

            Urun u2 = new Urun();
            u2.UrunID = 301;
            u2.UrunAdi = "armut";
            u2.Miktar = 34;
            s1.Urunler.Add(u2);

            Satis s2 = new Satis();
            s2.SatisTarihi = DateTime.Parse("02/02/2011 9:15AM");
            s2.SatisID = 1002;

            Urun u3 = new Urun();
            u3.UrunID = 302;
            u3.UrunAdi = "Kiraz";
            u3.Miktar = 14;
            s2.Urunler.Add(u3);

            Urun u4 = new Urun();
            u4.UrunID = 303;
            u4.UrunAdi = "portakal";
            u4.Miktar = 12;
            s2.Urunler.Add(u4);

            Urun u5 = new Urun();
            u5.UrunID = 304;
            u5.UrunAdi = "karpuz";
            u5.Miktar = 9;
            s2.Urunler.Add(u5);

            Urun u6 = new Urun();
            u6.UrunID = 305;
            u6.UrunAdi = "kavun";
            u6.Miktar = 8;
            s2.Urunler.Add(u6);

            Satis s3 = new Satis();
            s3.SatisTarihi = DateTime.Parse("03/03/2011 4:50PM");
            s3.SatisID = 1003;

            Urun u7 = new Urun();
            u7.UrunID = 306;
            u7.UrunAdi = "Kivi";
            u7.Miktar = 33;
            s3.Urunler.Add(u7);

            Urun u8 = new Urun();
            u8.UrunID = 307;
            u8.UrunAdi = "Muz";
            u8.Miktar = 10;
            s3.Urunler.Add(u8);

            Satis s4 = new Satis();
            s4.SatisTarihi = DateTime.Parse("04/04/2011 1:25 PM");
            s4.SatisID = 1004;

            Urun u9 = new Urun();
            u9.UrunID = 308;
            u9.UrunAdi = "Kereviz";
            u9.Miktar = 12;
            s4.Urunler.Add(u9);

            satisListesi.Add(s1);
            satisListesi.Add(s2);
            satisListesi.Add(s3);
            satisListesi.Add(s4);

            return satisListesi;




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
            Urunler = new List<Urun>();
        }

        public Satis(int satisID, DateTime satisTarihi)
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
        public int Miktar { get; set; }

      }

        class Adres
        {
            public string Adres1 { get; set; }
            public string Il { get; set; }
            public string Ilçe { get; set; }
            public string PostaKodu { get; set; }

        }
    
}

