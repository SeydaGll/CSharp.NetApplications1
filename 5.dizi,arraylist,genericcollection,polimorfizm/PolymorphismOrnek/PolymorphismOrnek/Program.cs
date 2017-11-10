using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek  // encapsulation,inheritance,polimorfizm OOP ın 3 temel konusu bunlar
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // artık tüm çöpler bir kutuya atılabilir. ayrıştırılma sonradan yapılacak
            List<Urun> envanter = new List<Urun>();
            Otomobil oto1 = new Otomobil();
            oto1.UreticiFirma = "BMW";
            oto1.Model = "X6";
            oto1.Renk = "Siyah";
            oto1.UrunNo = 147; // 147 numaralı ürün

            Telefon tel1 = new Telefon();
            tel1.Uretici = "Nokia";
            tel1.Model = "5110";
            tel1.GoruntuluKonusma = false;
            tel1.Fiyat = "10";
            tel1.UrunNo = 250;

            Giyim giy1 = new Giyim();
            giy1.UrunTipi = "Yazlık";
            giy1.Firma = "PUMA";
            giy1.Fiyat = 50;
            giy1.UrunNo = 365;

           

            envanter.Add(tel1);
            envanter.Add(oto1);
            envanter.Add(giy1);

            foreach (Urun item in envanter)
            {
                item.Yazdır();
            }
            Console.ReadLine();
            // normalde list tek tip alır ama ben polimmorfizm ile farklı tip alabldim. tüm ürünleri bir ürün çatısı altında toplamak için kullanılan kallıtıım yöntemidir...
            // biz tüm ürünleri ekledik. ayrıştırma içerisine kaldı . bunun herhangi bir değer olup olmaması önemli değil.içersindeki değerlerin ne şekilde olduğunu c# anlıcak
            // pollimorfizm faydali bir işlemdir...
        }
    }
}
