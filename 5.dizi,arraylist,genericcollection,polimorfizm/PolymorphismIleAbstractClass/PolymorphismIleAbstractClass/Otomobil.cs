using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleAbstractClass
{
    class Otomobil:Urun  // burda ürün içerisinde bulunan abstarct metodu implement etmek ZORUNDASIN.....
    {
        public string Uretici { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }


        public override void Yazdır()
        {
            Console.WriteLine(Uretici + "    " + Model + "     " + Fiyat);
        }
    }
}
