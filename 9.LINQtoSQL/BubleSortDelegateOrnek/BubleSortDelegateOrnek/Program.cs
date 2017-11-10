using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSortDelegateOrnek
{
    // Buble sort uygulamasını yazmak için buradaki kabarcık sıralama işlemini yapalım
    delegate bool SiralamaKarsilastirma<Tip>(Tip ilkDeger, Tip sonDeger);  // artık delegate global olarak tanındı..delegate i bir koleksiyon olarak tanımladık..



    class Program
    {
        public class BubleShort
        {
            static public void Sirala<Tip>(List<Tip> siralaList, SiralamaKarsilastirma<Tip> karsilastirma) //1) delegenin kullanılmasından dolayı Sirali diye bit metot yazıldı
            {
                bool sirali = true;  // sıralamanın bitip bitmediğini görmem için bir tane bool değer tanımlıyorum
                do
                {
                    sirali = false;
                    for (int i = 0; i < siralaList.Count - 1; i++)
                    {
                        if (karsilastirma(siralaList[i + 1], siralaList[i]))
                        {
                            Tip temp = siralaList[i];
                            siralaList[i] = siralaList[i + 1];
                            siralaList[i + 1] = temp;
                            sirali = true;
                        }
                    }
                } while (sirali);
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Satış lİStesi varsayılan");
            //git benim içiçn bazı metodlar tanımmla ve daha sonra yeni delegate ler tanımla ve bunların akabinde buradaki projeyş kullan 
            List<Satis> satisListesi = SatisListesiHazirla();

            foreach (Satis item in satisListesi)
            {
                Console.WriteLine(item.SatisID + " " + item.SatisTarihi + " " + item.SatisTutari);
            }


            BubleShort.Sirala<Satis>(satisListesi, Satis.SatisListesiniTutaraGoreHazirla);  // bunu çağırabilemem için Satis sınıfınn içerisinde delegate in kullanmış olduğu tarzda metodlar olması lazım
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Satış Tutarına Göre Sıralı Olan Bir Liste...");
            foreach (Satis item in satisListesi)
            {
                Console.WriteLine(item.SatisID + " " + item.SatisTarihi + " " + item.SatisTutari);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Satış Tarihine göre bir sıralama yap");
            BubleShort.Sirala<Satis>(satisListesi, Satis.SatisListesiniTariheGoreHazirla);  // bunun içerisine <string> verseydim tipi string olarak değerlendirecekti. yazıp parantez açtığımızda string bir liste isteyecektir. List<string>
            foreach (Satis item in satisListesi)
            {
                Console.WriteLine(item.SatisID + " " + item.SatisTarihi + " " + item.SatisTutari);
            }

            Console.WriteLine();
            Console.WriteLine();
            List<int> sayilarim = new List<int>() { 234, 33, 245, 568, 2567, 1 };

            BubleShort.Sirala<int>(sayilarim, MyClass.SayiSirala);
            foreach (int item in sayilarim)
            {
                Console.WriteLine(item);
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

    class MyClass
    {
        static public bool SayiSirala(int i1,int i2)
        {
            return i1 < i2; // buradaki mantıksal ifade sayesinde true yada false değeri dönücektir...
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
}
