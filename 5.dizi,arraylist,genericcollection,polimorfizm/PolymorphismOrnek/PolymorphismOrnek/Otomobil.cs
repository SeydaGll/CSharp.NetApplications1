using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    class Otomobil:Urun
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public override void Yazdır()
        {
            base.Yazdır();
            Console.WriteLine("{0} Ürettiği {1} Model de {2} renginde bir araçtır",UreticiFirma,Model,Renk);
        }
    }
}
