using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun4Odev
{
    public class Personel : VarlikBilgileri
    {
        public Personel(string kodAdi, string sehir, string yetenek, string departman)  // yapıcı metod
        {
            KodAdi = kodAdi;
            Sehir = sehir;
            YerDurum = yetenek;
            Departman = departman;
            Console.WriteLine($"Kod adınız : {KodAdi}, Şehiriniz : {sehir}, Yönetici : {yetenek}, Departmanınız : {departman}");
        }

        public string Departman { get; set; }

        public string Yonetici { get; set; }

    }
}
