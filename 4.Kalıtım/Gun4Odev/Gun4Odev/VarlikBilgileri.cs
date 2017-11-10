using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4Odev
{
   public class VarlikBilgileri
    {
        public string KodAdi { get; set; }
        public string Sehir { get; set; }
        public string YerDurum { get; set; }
        public virtual void Yazdir() // üzerine yazılabilir cins demek istiyorum yani ana class dakini sanal yapabiliyouz
        {
            Console.WriteLine("{0}  ({1})  {2}",KodAdi,Sehir,YerDurum); // string format,yazdığın string leri istersen bir formata göre yazablirsin
        }
    }
}
