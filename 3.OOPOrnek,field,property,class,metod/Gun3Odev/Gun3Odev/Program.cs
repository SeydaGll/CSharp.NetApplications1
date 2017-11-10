using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir firmaya ait bilgiler girildiği taktirde çalışanların isimleri daha sonradan direk olarak firmaya verilebilsin
            // bir çalışan değeri oluşturmak ve bununda firma ile ilişkilendirilmesi
            //not: Firma.FirmaBilgisi() ile bulunan metod değerimizin ve SirketBilgisiGoster() metodlarının içeriğini doldur.
            // istediğiniz taktide Firmaya ait ve çalışanlara ait  bilgileri bu metodlar sayesinde verin
            // diğer şart ise bu metdolardan sadece SirgetBilgisiGoster() metodunu kullanmanız. yani program.cs tarafında sadece SirgetBilgisiGoster() metodunu çağırarak 
            // buradaki tüm bilgilere ulaşabilelim. tavsiye FirmaBilgisiOKu() metodunu SirgetBilgisiGoster() metodunda kulllan ve bu sayede fazla işlem yapmaktan kurtul

            

            Firma uzmanAkademi = new Firma { CalisanSayisi = 299, FirmaAdi = "Uzman Bilişim Akademisi",Sehir = "Konya" };

            Calisan eleman = new Calisan { ElemanAdi="İlker Işık", ElemanUnvan="Programcı",IsGirisZamani=DateTime.Now,Sirket=uzmanAkademi };

            eleman.SirketBilgisiGoster(); // bu metodu çağırdığımda bana bilgiler gelmesi lazım

           
        }
    }
}
