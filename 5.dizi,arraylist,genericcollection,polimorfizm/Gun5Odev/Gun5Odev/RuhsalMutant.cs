using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev
{
    class RuhsalMutant:Mutant
    {
        public int GucKullanimMiktari { get; set; }
        public int IQ { get; set; }

        public override int TehlikeliBolum()
        {
            return Bolum * IQ * GucKullanimMiktari;
            //int sonuc = Bolum * IQ * GucKullanimMiktari;
            //return sonuc;
        }
    }
}
