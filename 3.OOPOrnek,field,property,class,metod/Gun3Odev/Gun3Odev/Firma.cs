using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3Odev
{
    public class Firma  // calıanlara ait firma özelliklerini buraya tanımlıyorum ve bunu calısan ile özleştiricem
    {
        private int calisanSayisi;
        private string firmaAdi;
        private string sehir;

        public int CalisanSayisi
        {
            get { return calisanSayisi; }
            set { calisanSayisi = value; }
        }
        public string FirmaAdi
        {
            get { return firmaAdi; }
            set { firmaAdi = value; }
        }
        public string Sehir
        {
            get { return sehir; }
            set { sehir = value; }
        }
            

        public string FirmaBilgisiOku()
        {
            string mesaj = "";
            mesaj = "Firma Adı...: " + FirmaAdi + " Şehir...:"+Sehir + " Çalışan Sayısı..:" + CalisanSayisi ;
            return mesaj;
        }
    }
}
