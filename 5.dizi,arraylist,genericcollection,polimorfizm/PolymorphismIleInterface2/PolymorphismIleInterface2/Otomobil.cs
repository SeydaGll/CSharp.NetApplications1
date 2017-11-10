using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Otomobil : IYazdir,IUrun //otomobil Iyazdır interface ini miras almış ise Iyazdır içindeki Yazdır() metodunu kullanmak zorundadır
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int KM { get; set; }
        public string Renk { get; set; }


        public void Yazdir()
        {
            Console.WriteLine("{0} , {1} , {2} , {3} (Renk):{4}",UreticiFirma,Model,Yil,KM,Renk);
        }
        public void DepolananDegeriOku()
        {
            Console.WriteLine("{0} firmasının ürettiği {1} modeldeki arac ambarın B bölümünde bulunmaktadır",UreticiFirma,Model);
        }

        
    }
}
