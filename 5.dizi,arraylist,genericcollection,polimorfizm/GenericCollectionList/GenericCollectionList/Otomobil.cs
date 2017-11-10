using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Otomobil
    {
        public string UreticiFirma { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public void Yazdır()
        {
            Console.WriteLine("{0} firmasının Ürettiği {1} renginde {2} modelli aracı incelemektesiniz..",UreticiFirma,Renk,Model );

        }
    }
}
