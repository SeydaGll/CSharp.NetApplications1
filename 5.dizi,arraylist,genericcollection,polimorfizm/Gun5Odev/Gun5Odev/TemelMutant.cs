using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev
{
    class TemelMutant:Mutant  // normal mutant
    {
       public int Bolge { get; set; }

        public override int TehlikeliBolum()
        {
            return Bolum * Bolge;
           
            
        }
    }
}
