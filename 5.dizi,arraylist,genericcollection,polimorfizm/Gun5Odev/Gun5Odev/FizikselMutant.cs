using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev
{
    class FizikselMutant:Mutant
    {
        public int Guc { get; set; }
        public int IQ { get; set; }

        public override int TehlikeliBolum()
        {
            return Bolum * IQ * Guc;
            //int sonuc = Bolum * IQ * Guc;
            //return sonuc;
        }
    }
}
