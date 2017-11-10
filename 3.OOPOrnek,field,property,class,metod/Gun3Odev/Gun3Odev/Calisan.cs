using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3Odev
{
    public class Calisan
    {
        private string elemanAdi;
        private string elemanUnvan;
        private DateTime isGirisZamani;
        private Firma sirket;  // Firma veri tipi. özleştirdik.int değerini kendi açımızdan tanımladık. Firma bir nevi int gibi.yani veri tipi.kendine ait bir veri tipi


        public string ElemanAdi {
            get { return elemanAdi; }
            set { elemanAdi = value; }
        }
        public string  ElemanUnvan
        {
            get { return elemanUnvan; }
            set { elemanUnvan = value; }
        }
        public DateTime IsGirisZamani
        {
            get { return isGirisZamani; }
            set { isGirisZamani = value; }
        }
        public Firma Sirket  // BAĞLANTIYI YAPmış olduk
        {
            get { return sirket; }
            set { sirket = value; }
        }

            
        public void SirketBilgisiGoster()
        {
            Console.WriteLine("Eleman Adı..:" + ElemanAdi);
            Console.WriteLine("Eleman Unvanı..:"+ElemanUnvan);
            Console.WriteLine("İşe Giriş Zamanı..:" + IsGirisZamani.ToString());
            Console.WriteLine(Sirket.FirmaBilgisiOku());
            
        }




    }
}
