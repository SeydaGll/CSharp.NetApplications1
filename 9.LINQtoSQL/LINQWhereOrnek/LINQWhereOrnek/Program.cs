﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWhereOrnek // where nerede sorularına cevap arayan ifadedir. ve c# içerisinde hem linq içerisinde bir keyword olarak kullanılabilir hemde extension bir metod olarak kullanılabilir
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Satis> satisListesi = SatisListesiHazirla();  // satislistesi içerisine nerede sorsunu sormak bizim amacımız
            var tumSatislarim = from s in satisListesi
                                select s;
            Console.WriteLine("tüm veriler ");
            foreach (var item in tumSatislarim)
            {
                Console.WriteLine("ID..:{0}, Tarih..:{1}, Urun Adet..:{2}",item.SatisID,item.SatisTarihi,item.Urunler.Count);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorgulama başlıyor");
            //1.işlem
            //var satislarim = from s in satisListesi where s.SatisID == 1002 select s;

            //2.işlem
            //var satislarim = from s in satisListesi where s.Urunler.Count > 3 select s;

            //3.işlem
            //var satislarim = from s in satisListesi where s.SatisTarihi > Convert.ToDateTime("12/02/2011") && s.Urunler.Count > 1 select s;

            //4.işlem
            //var satislarim = from s in satisListesi where s.SatisTarihi > DateTime.Parse("12/03/2011") || s.Urunler.Count > 3 select s;

            //5.işlem  extension metod ile yapalım
            //var satislarim = satisListesi.Where(s => s.SatisTarihi > DateTime.Parse("12/03/2011")).Select(s => s); // seelct yapmasanda olur

            //6.işlem
            //var satislarim = satisListesi.Where(s => s.SatisID == 1003);

            //7.işlem
            //var satislarim = satisListesi.Where(s => s.Urunler.Count <= 2);

            //8.işlem
            //var satislarim = satisListesi.Where(s => s.SatisTarihi > DateTime.Parse("01/01/2011") && s.Urunler.Count > 2);

            //9.işlem
            //var satislarim = satisListesi.Where(s => s.SatisID == 1001 || s.SatisTarihi > Convert.ToDateTime("03/03/2011"));

            //10.işlem   && yazmadan nasıl kullanılır
            var satislarim = satisListesi.Where(s => s.SatisID == 1003).Where(s => s.SatisTarihi > Convert.ToDateTime("01/01/2012"));

            


            foreach (var item in satislarim)
            {
                Console.WriteLine("ID..:{0}, Tarih..:{1}, Urun Adet..:{2}", item.SatisID, item.SatisTarihi, item.Urunler.Count);
            }


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




