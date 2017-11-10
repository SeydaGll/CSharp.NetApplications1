using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    class Giyim:Urun
    {
        public string UrunTipi { get; set; }
        public string Firma { get; set; }
        public int Fiyat { get; set; }

        public override void Yazdır()
        {
            base.Yazdır();
            Console.WriteLine("{0}  {1}  {2}",UrunTipi,Firma,Fiyat);
        }
    }
}
