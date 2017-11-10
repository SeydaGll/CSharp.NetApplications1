using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Oyuncak : IYazdir, IUrun
    {
        public string Imalatci { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }



        public void DepolananDegeriOku()
        {
            Console.WriteLine("Oyuncak --> {0} , {1} , (Fiyat):{2}",Imalatci,Adi,Fiyat);
        }

        public void Yazdir()
        {
            Console.WriteLine("{0}  oyuncak ambarın C bölümün bulunmaktadır",Adi );
        }
    }
}
