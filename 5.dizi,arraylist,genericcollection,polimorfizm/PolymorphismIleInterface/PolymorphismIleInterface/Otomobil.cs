using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface
{
    class Otomobil:IYazdır
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }

        public void Yazdir()
        {
            Console.WriteLine(UreticiFirma +" "+Model+" "+Fiyat );
        }
    }
}
