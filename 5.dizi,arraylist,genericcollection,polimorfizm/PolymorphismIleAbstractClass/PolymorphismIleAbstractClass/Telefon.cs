using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleAbstractClass
{
    class Telefon:Urun
    {
        public string Uretici { get; set; }
        public string Model { get; set; }

        public override void Yazdır()
        {

            Console.WriteLine("Üretici Firma ..:" + Uretici + "Model..:" + Model);
        }
    }
}
