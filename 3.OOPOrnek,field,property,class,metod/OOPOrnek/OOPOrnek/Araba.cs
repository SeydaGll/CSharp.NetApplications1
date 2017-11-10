using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Araba // kalıp halinde arabayı oluşturcaz. class niteliğinde . bir araba firması barındırıyoruz ve bu arabanın genel özelliklerini bir kalıp halinde burada yazmaya çalışıcaz
    {
        private string ureticiFirma;  // bunlar field lardır. yani tanımlanmış alanlardır
        public string model;
        public int uretimYili;
        public string renk;
        public int km;
        private int hiz;

        public Motor Motor; // bu mantıksal olarak veri tipidir ama c# tarafından sınıf olarak algılanacaktır. kendi veri tipimizi oluşturduk aslında. int gibi..
        // ureticiFirma yı private yaptık bu sınıftan görünüyor sadece.diğer yerlerden ulaşılamıyor. sonra diyoruz ki buna bir encapsuation işlemi gerekli
        // yani field encapsulation işlemi sonucunda çıkan ürün property dir. 

        //public string UreticiFirma  // PROPERTY haline getirilirken baş harfi büyük olcaktır. o yüzden değişkeni küçük harfle başlatmak önemli
        //{
        //    get { return ureticiFirma; } // bu proprty nin okunmasında kullanılacak değerdir. eğer okunmak istenir ise geriye döndür. döndürmen gereken değer sadece araba class ına has 
        //                                        //olan ureticiFirma değişken değerri. okunmak istediğinde buradaki değer gidecek
        //    set { ureticiFirma = value; }  // yazılması isteniyorsa benim için bu değerin verilmesi. ureticiFirma adı altında bulunan değişken değerine yaz.yazılan değer value değeri
        //}                   // yani dışardan  yazılan value değeri !!

        // field dan property i ayıran özellik nelerdeir??bir propery kayıt ve okuma sırasında akan aradaki bilgiyi kontrol etmek amacıyla kullanılan yapılardır.switch case kullanalım
        public string UreticiFirma
        {
            get { return ureticiFirma; }

            set {
                switch (value)
                {
                    case "BMW":
                        ureticiFirma = value;
                        break;
                    case "Honda":
                        ureticiFirma = value;
                        break;
                    default:
                        throw new Exception("İstenilen firma kaydı bulunamadı..."); // hata mesaji yazdırdık..
                        
                }
                // toyota yazdım hata verdi. bu şekilde akan bir bilginin kontolunu property ile sağlayabiliriz.
                // eğer gidip field e yazsaydık birşey farketmezdi herşeyi kabul eder. çünkü herhangi bir kontrol yaptırmadık.yani property lerde bu şekilde bir kontrol mekanizası
                // kurabiliriz....eğer istediğiniz şartlar uygun değilse bu şekilde bir kaydın daha olmayacağını burdan söyleyebiliriz...
                //ureticiFirma = value; }  
            }
        }

        // bir property daha oluşturalım.. hız kotrolünü içerde yapacağım bir ifade olsun .hız değerimiz  eksiye inemez !

        public int Hiz  // hiz Hiz property sinin kontrol etmekte kullanılan bir tampon diyebiliriz.hiz müsvette , Hiz ise değerin  ve metnin en son orjinal olarak verilmesi gereken değer 
        {                                   // olarak genelleme altına alabilriz.
            get { return hiz; }  // hız değerini oku!!
            set {
                if (value < 0)
                    hiz = 0;
                else if (value > 210)
                    hiz = 210;
                else
                    hiz = value;


            }
        }
        // void metodlarda kullanıldığında geriye değer döndürmeyen anlamındadır
        public int /*void*/ Hizlandir()  // arabımızın hızını artıran metod olsun  // hızlandırılınca yapması gereken değerleri yazalım
        {
            Hiz = Hiz + 10; // metod her çağrıldığında hız 10 km artıcak
            // hiz += 10;
            /*Console.WriteLine("Hızlanıyorsunuz!! Şuandaki hızınız ... : " + hiz);*/
            return hiz; // hızdeğeri 10 artırılık Hızlardır() ı kullanılan yere int değeri vericektir
        }

        public int Yavaslat(int hizDegeri)
        {
            Hiz -= hizDegeri;
            //Console.WriteLine("Yavaşlıyorsunuz!! Şuandaki hızınız... :" + hiz);
            return Hiz;
        }

        public int Hizlandir1(int hizDeger)  // kullanıcı hiz değerini veriyor
        {
            Hiz = Hiz + hizDeger;
            return Hiz;
        }

        public string HizKontrol()
        {
            string mesaj = "";
            if (hiz > 50)
                mesaj = "Hız Limitini aştınız...Dikkat Ediniz !!! ";
            else
                mesaj = "Hız Limitiniz Normal...";
            return mesaj;
        }
     }
}
// geriye değer  döndürmeyen metot yani void : örneğin bir şirket bünyesinde çalışıyorsunuz ve sizden iş yapmanız istendi. eğer ki bu işi yapıp bunun cevabını bir kişiye vermek zorunda 
// değil iseniz bu sizin için geriye değer vermek zorunda olmadığınız  yapmak zorunda olduğunuz durumlardır. buda aynı şekilde c# ortamında geçerlidir.
