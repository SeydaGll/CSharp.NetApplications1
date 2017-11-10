using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleAbstractClass // polimorfizm ile soyut sınıflar
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Urun> envanter = new List<Urun>();  // git benim için urun adı altında koleksiyon oluştur

            Telefon t1 = new Telefon();
            t1.Uretici = "Nokia";
            t1.Model = "3310";
            t1.UrunNo = 123;

            envanter.Add(t1);

            Otomobil o1 = new Otomobil();
            o1.Uretici = "Toyota";
            o1.Fiyat = 15000;
            o1.Model = "Corolla";
            o1.UrunNo = 123;

            envanter.Add(o1);


            Console.WriteLine("Envarterdeki Araçlar");
            foreach (Urun item in envanter)
            {
                item.Yazdır();  // burda yazılan Urun deki Yazdır metodu ama burda Telefon Ve otomobildeki yazdır ı kullanacağını unutma:çünkü en son dğerleri üzerine yazdırdık
            }




            Console.ReadLine();

        }
    }
}
