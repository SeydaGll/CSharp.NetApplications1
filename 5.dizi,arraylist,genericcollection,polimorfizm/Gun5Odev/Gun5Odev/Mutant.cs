using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev
{
    abstract class Mutant:IGoruntu
    {
        public int Bolum { get; set; }  // nonabstract
        public string KodAdi { get; set; }  //nonabstarct

        public abstract int TehlikeliBolum();  // abstarct

        public void GorunumBilgisi()
        {
            Console.WriteLine("Kod ADI....:"+KodAdi+"  Tehlike Sınırı...:" + TehlikeliBolum().ToString());
            
        }
    }
}
