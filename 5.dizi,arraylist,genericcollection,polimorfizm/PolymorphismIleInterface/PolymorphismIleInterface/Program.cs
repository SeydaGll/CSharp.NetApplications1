using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface // polimorfizm yöntemi ile interface, br interface nasıl tanımlanır, polimofizm ile nasıl ifade edili.(arayüz). interface DEĞERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IYazdır> envanter = new List<IYazdır>(); // içerisine interface alsın diyorum
            
            Otomobil o1 = new Otomobil();
            o1.UreticiFirma = "BMW";
            o1.Model = "x5";
            o1.Fiyat = 85000;
            
            envanter.Add(o1);

            Telefon t1 = new Telefon();
            t1.Firma = "NOKİA";
            t1.Model = "5110";

            envanter.Add(t1);

            

            foreach (var item in envanter)  // var keyword ü aranılan değerin tipini otomatik olarak anlar..envanter in içindeki tipi ben bilmek zorunda değilim.IYazdir tipide yazabilirsin
            {
                item.Yazdir();
            }

            Console.ReadLine();


        }
    }
}
