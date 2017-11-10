using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UrunBilgi class ı yardımıyla yeni bir liste oluşturucaz. bu liste içerisinde sadece bu ürünün adını ve turatını göstericez.daha sonra bu iki tabloyu birbiryle ilişkilendiricez ve bunu sayesinde joın değerin görücez.. 
// satisList in içerisinde urunler içerisinde bulunan değerlerden herhangi biri yok . birbirine bağlı değil


namespace LINQFromVeJoın
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UrunBilgi> urunler = new List<UrunBilgi>() {
            new UrunBilgi { UrunAdi="Elma", UrunTutar = 19.95M},
            new UrunBilgi { UrunAdi="Armut", UrunTutar = 29.95M},
            new UrunBilgi { UrunAdi="Muz", UrunTutar = 39.95M},
            new UrunBilgi { UrunAdi="Portakal", UrunTutar = 21.95M},
            new UrunBilgi { UrunAdi="Karpuz", UrunTutar = 49.95M},
            new UrunBilgi { UrunAdi="Kiraz", UrunTutar = 25.95M},
            new UrunBilgi { UrunAdi="Kivi", UrunTutar = 12.95M},
            new UrunBilgi { UrunAdi = "Kereviz", UrunTutar = 33.95M },
            new UrunBilgi { UrunAdi="Kavun", UrunTutar = 22.95M}};


            List<Satis> satisList  = SatisListesiHazirla();

            // joın ile iki tabloyu ilişkilendiricez.sql deki inner joın le aynı
            //1.işlem
            //var bilgi = from s in satisList
            //            from ui in s.Urunler
            //            join u in urunler on ui.UrunAdi equals u.UrunAdi // == kullanmak yerine equals kullandık. eşit mi sorgusu yaptrıyor
            //            select new { u.UrunAdi, s.SatisTutari, s.SatisID, ui.Miktar };
            //foreach (var item in bilgi)
            //{
            //    Console.WriteLine(item);
            //}

            //2.işlem
            //var bilgi = from s in satisList
            //            from ui in s.Urunler
            //            select ui;
            //var bilgi2 = from u in urunler
            //             join m in bilgi on u.UrunAdi equals m.UrunAdi
            //             into suList
            //             select new { u.UrunAdi, suList };
            //foreach (var u in bilgi2)
            //{
            //    Console.WriteLine("Urun..:"+u.UrunAdi);
            //    foreach (var item in u.suList)
            //    {
            //        Console.WriteLine("        ID..:{0},   Miktar..:{1}",item.UrunID,item.Miktar);
            //    }
            //}

            //3.işlem extension metod ile joın.. birden fazla tablo birden fazla değer seçmek için kullanılan bir değer selectmany
            //var satisListem = satisList.SelectMany(s => s.Urunler).Join(urunler, ui => ui.UrunAdi, j => j.UrunAdi, (ui, j) => ui);
            //var bilgi = satisList.SelectMany(s => s.Urunler.Join(urunler, ui => ui.UrunAdi, j => j.UrunAdi, (ui, j) => new { j.UrunAdi, j.UrunTutar, ui.Miktar, s.SatisID }));
            //foreach (var item in bilgi)
            //{
            //    Console.WriteLine(item);
            //}

            //4.işlem   2. işlemle aynı
            var bilgi = urunler.GroupJoin(satisList.SelectMany(s => s.Urunler), u => u.UrunAdi, m => m.UrunAdi, (u, uList) => new { urunAdi = u.UrunAdi, uList });
            foreach (var item in bilgi)
            {
                Console.WriteLine("Urun: "+item.urunAdi);
                foreach (var item2 in item.uList)
                {
                    Console.WriteLine("      ID..:{0}",item2.UrunID);
                }
            }





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
            u2.UrunAdi = "Armut";
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
            u4.UrunAdi = "Portakal";
            u4.Miktar = 12;
            s2.Urunler.Add(u4);

            Urun u5 = new Urun();
            u5.UrunID = 304;
            u5.UrunAdi = "Karpuz";
            u5.Miktar = 9;
            s2.Urunler.Add(u5);

            Urun u6 = new Urun();
            u6.UrunID = 305;
            u6.UrunAdi = "Kavun";
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

            Urun u10 = new Urun();
            u10.UrunID = 309;
            u10.UrunAdi = "Elma";
            u10.Miktar = 25;
            s4.Urunler.Add(u10);

            satisListesi.Add(s1);
            satisListesi.Add(s2);
            satisListesi.Add(s3);
            satisListesi.Add(s4);

            return satisListesi;




        }
    }
    class UrunBilgi
    {
        public string UrunAdi { get; set; }
        public decimal UrunTutar { get; set; }
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
}
