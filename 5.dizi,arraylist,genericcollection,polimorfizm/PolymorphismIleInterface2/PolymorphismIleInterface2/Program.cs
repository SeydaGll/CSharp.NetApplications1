using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil();
            oto.UreticiFirma = "BMW";
            oto.Model = "x6";
            oto.KM = 20000;
            oto.Yil = 2011;
            oto.Renk = "Siyah";

            Telefon tel = new Telefon();
            tel.Firma = "NOKIA";
            tel.Model = "e71";
            tel.Fiyat = 499.99;


            // buradaki değerleri önceki derste koleksiyon tanımayarak yazdırmıştık.. şimdi koleksiyon tanımlamadan nasıl yazdırabilriz
            // bunun için proje içersine bazı metodları yazabileceğim bir class daha oluşturcam 

            Console.WriteLine("İşlem 1....");
            Yazdir.ConsoleDegerYaz(oto);
            Yazdir.ConsoleDegerYaz(tel);


            Console.WriteLine("Birinci işlem tamamlandı");
            Console.ReadLine();

            // tüm ürünlerimi barındırabiilceğim bir class daha oluşturcam
            Console.WriteLine();
            Console.WriteLine("2.İŞLEM");
            Console.WriteLine();

            Ambar benimAmbar = new Ambar(); // BURDA constractor devreye giricek ve eni bir envanter adı altında bulunan yeni generic koleksiyon oluşacak
            // buradaki koleksiyonum FIFO tarzındagörev yapan bir koleksiyon
            benimAmbar.Ekle(tel);
            benimAmbar.Ekle(oto);

            var benimEskiUrun = benimAmbar.EskiDegeriOku(); // benimEskiUrun un içerisinde artık ınterface var
            benimEskiUrun.DepolananDegeriOku();

            Console.WriteLine("2.İşlem tamam");
            Console.ReadLine();

            Console.WriteLine("3.İşlem başlıyor");

            Console.WriteLine();

            Oyuncak benimOyuncak = new Oyuncak() { Imalatci = "ABC AŞ.", Adi = "Konusan otomobil", Fiyat = 250 };
            Console.WriteLine("Yeni deger ekleniyor.....");
            Yazdir.ConsoleDegerYaz(benimOyuncak);

            Console.WriteLine();
            Console.WriteLine("En yeni eklenen ürün hangisi ve nerede?");

            benimAmbar.Ekle(benimOyuncak);
            var yeniUrun = benimAmbar.YeniDegeriGonder();
            yeniUrun.DepolananDegeriOku();
            Console.WriteLine("İŞLEM TAMAMMM");
            Console.ReadLine();





            
        }
    }
}
