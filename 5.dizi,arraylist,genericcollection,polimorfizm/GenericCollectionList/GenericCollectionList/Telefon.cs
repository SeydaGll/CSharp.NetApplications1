using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Telefon
    {
        public string Model { get; set; }
        public string Firma { get; set; }

        public void Yazdır()
        {
            Console.WriteLine(Model);
            Console.WriteLine(Firma);
        }
    }
}
