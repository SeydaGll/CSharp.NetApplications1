using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Araba
    {
        public UreticiFirmalarım UreticiFirma { get; set; } 



        public virtual void Baslat() // virtuaş: sanal
        {
            Console.WriteLine("Araç çalıştırıldı.");
        }

        public void Degerlerim(UreticiFirmalarım firma)
        {
            switch (ConsoleColor)  // enumlar swtich case ile kullanımı gayet kolaydır..
            {
                    default:
                    break;
            }

        }

     }

    enum UreticiFirmalarım
    {
        BMW,
        Toyota,
        Mercedes,
        Honda
    }
}
