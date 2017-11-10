using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    public static class Yazdir // static  yani üretilmeyen bir class olsun.
    {
        public static void ConsoleDegerYaz(IYazdir yazdirabilirDeger) // static olan bir class ın içerisinde static olmayan bir nesne kullanılamaz..içerisine otomobil yada telefon alıcak
        {
            yazdirabilirDeger.Yazdir();  // burdaki yazdır metodu IYazdir dan geldi..
        }
    }
}
