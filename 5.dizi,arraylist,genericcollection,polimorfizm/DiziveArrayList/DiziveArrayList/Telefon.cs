using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziveArrayList
{
    class Telefon
    {
        public string UreticiFirma { get; set; }
        public string Marka { get; set; }
        public string Fiyat { get; set; }

        // "Nokia"
        public void Yazdır()
        {
            Console.WriteLine("\"{0}\", {1}  ((Fiyat..:{2}))",UreticiFirma,Marka,Fiyat);
        }
    }
}
