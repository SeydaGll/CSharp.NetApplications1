using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziveArrayList
{
    class Otomobil
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public int KM { get; set; }
        public string Renk { get; set; }

        public void Yazdır()
        {
            Console.WriteLine("{0} Yılında {1} Firmasının ürettiği {2} Modelde ve {3} Renginde bir araçtır. (KM..:{4})",Yil,UreticiFirma,Model,Renk,KM);
        }
    }
}
