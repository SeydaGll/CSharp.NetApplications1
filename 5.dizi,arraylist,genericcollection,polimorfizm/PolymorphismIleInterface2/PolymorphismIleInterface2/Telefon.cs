using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Telefon:IYazdir,IUrun
    {
        public string Firma { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

        public void DepolananDegeriOku()
        {
            Console.WriteLine("{0} , {1} Adlı Telefon Ambarın A Bölümünde bulunmaktadır....",Firma,Model);
        }

        public void Yazdir()
        {
            Console.WriteLine("{0}  {1}  (Fiyat):{2}",Firma,Model,Fiyat);
        }
    }
}
