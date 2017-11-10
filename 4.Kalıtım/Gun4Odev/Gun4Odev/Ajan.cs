using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4Odev
{
    class Ajan : VarlikBilgileri
    {
        public override void Yazdir()  //bu class ın içerisinden buna müdahale edilebilsin diyorum
        {
            Console.WriteLine("{0}.....{1}.....{2}", KodAdi, Sehir, YerDurum);
        }
    }
}
