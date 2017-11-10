using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gun2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TİPDÖNÜŞÜMÜ
            // bunların yanısıra değişken olarak ele alınmamış ama içerisinde değer barındırabilen bazı ifadeler vardır
            //System.DateTime --> Tarih
            DateTime simdi = DateTime.Now; // şimdiki tarih saat. metodu çağırdığım zaman simdi adlı değişken içersinde şimdiki tarih gün saat ifadelerinin hepsi barındırılacaktır

            string myName = "3";
            int x = 3;

            // dönüşüm için BİRİNCİ yöntem( cAST) İŞLEMİ
            int sicaklik = 35;
            byte derece = (byte)sicaklik; // böyle bir çevirme veri kaybına sebep olabilir.cast işlemi.

            string stringDeger = "6";
            int intDeger = 9;
            string deneme = stringDeger + intDeger;
            
            // dönüşüm için İKİNCİ yöntem metod çağırma ( toString() ) 
            string deneme1 = intDeger.ToString();  // toString ile string e dönüştürdük. 9 değeri artık deneme1 e string olarak yazılcaktır

            // dönüşüm için ÜÇÜNCÜ yöntem 
            intDeger = int.Parse(myName);  // Parse işlemi   
            
            // dönüşüm için DÖRDÜNCÜ yöntem --> kapalı tür dönşümü
            intDeger = Convert.ToInt32(myName);   // myName içerisinde karaktersel bir şey OLMAMALI!!! FORMATEXCEPTİON hatası alırsın yoksa  
            #endregion

            #region TEK SATIR IF
            // TEK SATIR İF-ELSE
            string message;
            if (x > y)
            {
                message = "500.000TL";
            }
            else
            {
                message = "10.0000TL";
            }

            string message = (x > y) ? "500.000TL" : "10.000TL"; // message değişkenine buradan çıkan sonuç yazdırılacaktır
                                                                 //x>y ? ile anlam kaznır. ? if i temsil eder. : else demektir .x büyük mü y den demek istemektetir. true ise 500.000 
                                                                 //mesaja yazdırılır,eğer false ise message a 10.000 yazılacaktır.  
            #endregion

            #region IF

            Console.WriteLine("1,2,3 giriniz");
            string deger = Console.ReadLine();
            //string sonuc;  // sürekli console.writeline() kullanmamak için önceden değişken tanımladık.aşağıda bir kere kullanmış olduk
            //if (deger =="1")
            //{
            //    sonuc = "500.000 kazandınız";
            //}
            //else if (deger=="2")
            //{
            //    sonuc = "100.000 kazandınız";
            //}
            //else if (deger=="3")
            //{
            //    sonuc = "10.000 kazandınız";
            //}else
            //{
            //    sonuc = "kazanamadınız";
            //}
            //Console.WriteLine(sonuc); 
            #endregion

            //karar yapıları
            #region switch
            //switch (deger) // eğer switch in içerisindeki değer bir string ise tüm case lerin değerleri string olmak zorundadır. eğer int ise tüm case ler int omak zorundadır
            //{
            //    case "1":  // buşekilde yazılır.
            //        Console.WriteLine("500.000 tl");
            //        break;  // buda yazılmalı. buraya geldiğinde küme parantezlerinin dışına çıkar.diğer kod satırlarını devreye sokmaz
            //    case "2":
            //    case "6":  // çakışma olmaz.
            //        Console.WriteLine("100.000tl");
            //        break;
            //    case "3":
            //        Console.WriteLine("10.000TL");
            //        break;
            //    default: // buraya bir değer yazamayız
            //        Console.WriteLine("malesef kazanamadınz"); // case lerden herhangi biri değilse burası çalışır.
            //        break;
            //}

            //// BREAK; KEYWORD ÜNÜN KULLANILACAĞI BAZI ALANLAR VARDIR.. FOR,FOREACH,WHİLE GİBİ DÖNGÜLERDE KULLANILIR..!!!!İF ELSE KULLANILMAZ.... 

            //Console.ReadLine(); 
            #endregion

            #region FOR DÖNGÜSÜ
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("sayı değeri : " + i);
            //    if (i == 5)
            //    {
            //        Console.WriteLine("işlem tamam"); // for yapısında kullanılan bazı yapılar daha  vardır. mesela sayımız 1 den 10 kadar saysın ama 5 geldiği anda
            //        break;                                // bu döngüm tamamen bitsin. gri rengin arasındaki kodlar devreye girecektir(for-break). break for dan çıkmak için kullanılır
            //    }
            //}// int for da geçerlidir. global olmasını istiyosan global YAP...

            int i = 1;
            for (; i < 10; i++)  // for döngüsüde tek satır için süslü parantez kullanılmayabilir. sadee o satırı döner.. 
                Console.WriteLine(i);
            Console.WriteLine("işlem tamam");
            #endregion
            
            //döngüler
            while (true)  // ardışık işlemler için döngü yapılır. şirketimiz bünyasende şirketteki 1000 kişinin maaşını %5 artırmak istiyoruz
            {       // dışardan bir veri okurken dışarıda ne kadar veri olduğunu bilemeyiz. yani kaç satırdan oluşan bir veri var bilemeyiz.bundan dolayı while ile kontrol etmek daha İYİDİR.
                //deger = deger +1;  --> deger += 1; aynı şey
                
            }




        }
    }
}
//sbyte,byte,short,ushort,int,uint,long,ulong,float,double,decimal,bool,string,char
//decimal ve double sql server üzerinde değerlendireceğimz zaman para birimi olarak değerlendireceğimizi söyleyebilirz.