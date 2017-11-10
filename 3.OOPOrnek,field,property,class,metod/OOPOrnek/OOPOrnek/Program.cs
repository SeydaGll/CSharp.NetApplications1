using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OOPORNEK1
            //// demştikle sınıflarla kalıp oluşturuyoruz. buradaki kalıp araba.cs adı altında bulunan class değri. bu classı nasıl kullanıcam ve değeri nasıl görücem?
            //Araba benimArabam = new Araba();

            /*Console.BackgroundColor    // backgroundcolor bir proporty dir. yazının arka plan rengini değiştirmekte kullanılan bir özelliktir.bunun OLMAZSA OLMAZLARINDAN get ve set 
             özelliği vardır. bunlara c# tarafından get ve set özelliği ilave edilmiştir. get ve set avantaj mıdır dezavantaj mıdır?
             get özelliği backgroundcolor ın yani arka plan rengini OKUNMASI yani şuanda hangi renk var bunun okunmasındaki kullanılan yapıdır. get özelliği
             genellikle ookumak için kullanılan bir keyword tabirinden gelir
             set özelliği console uygulamasının arka plan rengini değiştirilmesi için kullanılan bir ayar ifadesidir. yani kayıt esnasında devreye giren bir değer
             dir diyebilriz. tüm property lerin get ve set özelliği olmak zorunda mıdır. hayır. sadece property lerin get özelliği olması yeterlidir. 
             yani bir propery sadece okunabilir olabilir. bunun içerisine isterseniz set özelliği yani kayıt özellği ekleyebilirsiniz. bunlar sizin isteğinize kalmış
             durumlardır. ve istediğiniz takdirde de bir kayıt işlemini gerçekleştirmezsiniz. ve bundan dolayıda sadece get özelliği zorunlu kılınmıştır. */

            //benimArabam.Hiz = 0;  // ŞUAN da arabamız duruyor. kontağı açtığımız zaman metod çağrılcak ve hızını artırmış olucak
            //benimArabam.UreticiFirma = "BMW";
            //benimArabam.model = "X6";
            //benimArabam.uretimYili = 2011;
            //benimArabam.km = 1000;

            //// burada değeri okumak için.. 
            //Console.WriteLine("Üretici Firma..:" + benimArabam.UreticiFirma + " Araba Model..:" + benimArabam.model);

            //// ben bir kalıp oluşturdum. bu kalıba göre değerleri girdim ve buna görede işlemler yaptırdım

            //// bunun metodları nasıl çağrılır?
            //int beniHizim = 0;
            //beniHizim = benimArabam.Hizlandir();
            //Console.WriteLine("Hızınız..:" + beniHizim);

            //benimArabam.Hizlandir1(30);
            //benimArabam.Hizlandir1(12);
            //benimArabam.Hizlandir1(43);



            //string hizKontrolMesaj = "";
            //hizKontrolMesaj = benimArabam.HizKontrol();
            //Console.WriteLine(hizKontrolMesaj);

            //benimArabam.Hizlandir1(2);
            //benimArabam.Hizlandir1(1);

            //beniHizim = benimArabam.Yavaslat(100);
            //Console.WriteLine("Hızınız..:" + beniHizim);


            ////Console.WriteLine("Şuandaki Hız Değeriniz .. : " + benimArabam.hiz);

            //// oluşturulan arayüzün diğer tarafta programın asıl template i üzerinden ne gibi çağrıldığı ve ne şekilde işleme tabi tutulduğunu gördük 
            #endregion

            Motor v4 = new Motor();
            v4.boyut = "v4";
            v4.beygirGucu = 200;
            v4.yakitTukOrani=1.6;   // ondalık ayraç için c# da . kullanılır , değil. 

            Motor v6 = new Motor();
            v6.boyut = "V6";
            v6.beygirGucu = 350;
            v6.yakitTukOrani = 2.6;

            Motor v8 = new Motor();
            v8.boyut = "v8";
            v8.beygirGucu = 500;
            v8.yakitTukOrani = 3.7;

            Araba myCar = new Araba();
            myCar.Motor = v8; // Arabanın içerisinde bulunan Motor adlı field burada bizim tanımlamış olduğumuz Motor ile birebir aynıdır. yani v8 nın içerisinde aslında
            // boyut,beygirGucu ve yakitTukOranı nin yazılı şekli bulunuyor..v8 Motor ifadesinin istediği değerdir. mesela int bir değerin karşısına string değer değil int değer yazarsın
            // burda da Motorun karşısına Motor değeri yazıcaksın yani v8 Motor değerine sahiptir. 

            //Console.WriteLine(myCar.Motor.boyut);
            //Console.WriteLine(myCar.Motor.beygirGucu.ToString());

            MotorMontaj arabaMontaj = new MotorMontaj();
            arabaMontaj.ArabaOlustur("730", v8);
            
            

            // bunları Araba class ı ile nasıl özleştiricem?? Araba class ına gidip bunu bir değer olarak tanımlamam gerekiyor. Araba class ın public Motor Motor; diye tanımladık.
            // bunu nasıl kullancaz ??
        }
    }
}
// CTRL K X  propfull, prop, cw, immediate Window(denetim ekranı)