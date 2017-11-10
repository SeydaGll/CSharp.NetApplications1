using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQProjectionOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Satis> satisListesi = SatisListesiHazirla();

            //1.işlem
            //var satislarim = from s in satisListesi select s;
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.SatisTutari);
            //}

            //2.işlem
            //var satislarim = from s in satisListesi select s.SatisTarihi;
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.ToShortDateString());
            //}

            //3.işlem
            //var satislarim = from s in satisListesi
            //                 select new { s.SatisTarihi, s.SatisTutari };   // yukarıdaki değer sadece bir değer seçerken bu iki değeri seçebilcek.. new ile
            //foreach (var item in satislarim)                    //new keyword ü bizim için yeni bir değer açtı ve iki değer seçmemizi istedi. fazla sayıda değer seçmek bu şekilde kulllanabilirz
            //{
            //    Console.WriteLine(item.SatisTarihi + " " + item.SatisTutari);
            //}
            //Console.WriteLine(satislarim.First().GetType());

            //4.işlem
            //var satislarim = from s in satisListesi
            //                 select new SatisBilgileri { SatisID = s.SatisID, SatisTarihi = s.SatisTarihi }; //veri tipinin satisBilgileri olarak değerlendirilen anonim bir veri tipi olduğu söylenir.
            //foreach (SatisBilgileri item in satislarim)
            //{
            //    Console.WriteLine(item.SatisID+" "+item.SatisTarihi);
            //}
            //Console.WriteLine(satislarim.GetType());

            //5 işlem
            //var satisXML = new XElement("Satislar", from s in satisListesi select new XElement("Satis", new XAttribute
            //                                        ("SatisTarihi", s.SatisTarihi.ToLongDateString()), new XAttribute("toplamMiktar", s.Urunler.Sum(i => i.Miktar))));
            //Console.WriteLine(satisXML.ToString());

            //6.işlem
            //var satislarim = from s in satisListesi from sb in s.Urunler select sb;
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.UrunID+" "+item.UrunAdi+" "+item.Miktar); // satişların üzerinden sadece buradaki ürünlerin değerini görebildim.iç içe iki tane sorgu yapmış olduk
            //}

            //7.işlme
            //var satislarim = satisListesi.Select(s => s); //git ve seç. benim için seçeceğin değerler benim için s olarak değerlendirilen bir işlem.benim için git tüm s değerlerini seç. yani benim için bulduğun tüm s değerini gör ve daha sonra s olarak bunu geriye gönder
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.SatisID+" "+item.SatisTarihi);
            //}

            //8.işlem
            //var satislarim = satisListesi.Select(s => s.SatisTarihi);  // 2. işlemle aynı
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item);
            //}

            //9.işlem
            //foreach (var item in satisListesi.Select(s=>s)) // var kullanmak yerine foreach kullanabilirsin
            //{
            //    Console.WriteLine(item.SatisID);
            //}

            //10.işlem
            //foreach (var item in satisListesi.Select(s=>s.SatisTarihi))
            //{
            //    Console.WriteLine(item);
            //}

            //11.işlem
            //var satislarim = satisListesi.Select(s => new { s.SatisID, s.SatisTutari });
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.SatisID+" "+item.SatisTutari);
            //}

            //12.işlem
            //var satisBilgisi = satisListesi.Select(s => new SatisBilgileri { SatisID = s.SatisID, SatisTarihi = s.SatisTarihi });
            //foreach (SatisBilgileri item in satisBilgisi)
            //{
            //    Console.WriteLine(item.SatisID+ " "+item.SatisTarihi);
            //}

            //13.işlem  // var kullanmadan yazdırma işlemi
            //foreach (SatisBilgileri item in satisListesi.Select(s => new SatisBilgileri { SatisID = s.SatisID, SatisTarihi = s.SatisTarihi }))
            //{
            //    Console.WriteLine(item.SatisID + " " + item.SatisTarihi);
            //}

            //14.işlem
            //var satisXML = new XElement("Satislar", from s in satisListesi select new XElement("Satis", new XAttribute("TARİH", s.SatisTarihi), new XAttribute("Miktar", s.SatisTutari)));
            //Console.WriteLine(satisXML);

            //15.işlem
            //var satislarim = satisListesi.SelectMany(s => s.Urunler); // içe içe from değeri kullanmıştık bunun yerine selectmany ile bir metodu kullanabilrim
            //foreach (var item in satislarim)
            //{
            //    Console.WriteLine(item.UrunID+" "+item.UrunAdi+" "+item.Miktar);
            //}

            //16.işlem
            var satisXML = new XElement("Satislar", satisListesi.Select(s => new XElement("Satis", new XAttribute("Tarih", s.SatisTarihi),
                new XAttribute("toplammiktar", s.Urunler.Sum(i => i.Miktar)))));
            Console.WriteLine(satisXML);

            //select değerini isterseniz extension metod değeriyle isterseniz de bir keyword yardımı ile kullanabilirsiniz..


            Console.WriteLine("");
            Console.WriteLine("Devam etmek için Enter'e basınız... ");
            Console.ReadLine();


        }


        static private List<Satis> SatisListesiHazirla()
        {

            List<Satis> satisListesi = new List<Satis>();

            Satis s1 = new Satis();
            s1.SatisTarihi = DateTime.Parse("01/01/2011 9:25AM");
            s1.SatisID = 1001;
            s1.SatisTutari = 250;

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
            s2.SatisTutari = 790;

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
            s3.SatisTutari = 104;

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
            s4.SatisTutari = 234;

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

        static public bool SatisListesiniTutaraGoreHazirla(Satis s1, Satis s2)
        {
            return s1.SatisTutari < s2.SatisTutari;
        }

        static public bool SatisListesiniTariheGoreHazirla(Satis s1, Satis s2)
        {
            return s1.SatisTarihi > s2.SatisTarihi;
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
    class SatisBilgileri
    {
        public DateTime SatisTarihi { get; set; }
        public int SatisID { get; set; }

    }
}
