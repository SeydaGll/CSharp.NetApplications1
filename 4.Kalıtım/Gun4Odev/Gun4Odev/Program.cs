using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel("Şeyda gelişli", "Türkiye", "mühendis", "yazılım departmanı");

            Analiz.AnalizYap(p);

            Ajan a = new Ajan();
            a.KodAdi = "007";
            a.Sehir = "ABD";
            a.YerDurum = "FBI";

            Analiz.AnalizYap(a);

            
        }
    }

}
