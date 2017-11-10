using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun1
{
    class Program
    {

        static void Main(string[] args)
        {
            #region ilkders
            //Console.WriteLine("Merhaba Dünya");  System.Console.WriteLine(); // böylede yazabiliriz
            //Console.ReadLine();
            //int x;  // intellisense (local variable) diyor.
            //int VKI;

            /*if-else..günlük hayattaki amacı ve kullanım yeri. bankamatik kartımız var.gidip bankomattan para çekmek üzere kartımızı makineye verdiğimiz taktirde bizim için karşıya
                ismimizin geldiğini görürüz.yani kartı verdiğim taktirde ismimin gelmesi if-else bloğu sayesinde gerçekleşiyor. ne şekilde? örneğin üzerinde verilmiş olan 25 karakterli rakamın 
                aslında benim için şeyda gelişliyi temsil eden bir numara olduğunu programcı tarafından uygulamaya konulmuş olan bir değerdir. yani benim için numara olarak 
                şeyda gelişli numarası 25 karakterden oluşan bir numara bir ıd dir.. bundan sonra benden bir şifre girmem söylenir. bu şifreyi makineye girdiğim taktirde bir eşitlik yapmak durumundadır. 
                yani benim önceden tanımlı şifremle sonradan tanımlı şifremin birbirine eğerki eşit ise benim için işlem yapmama olanak sağlar. if-else yapar.....telefonumuzun pin kodu,
                bilgisayara bağlanırken sorduğu şifre yine if-else ile kontrol edilen karar mekanizmalarından biridir....*/

            //yarışmadasınız.yarışmanın içerisinde 3 adet para dolu kutu var ve bu kutulardan birini seçmemiz isteniyor
            //Console.WriteLine("1,2 ve 3 numaralı Para Kutularından birini seçiniz");
            //string deger = Console.ReadLine();
            //string sonuc;  // string sonuc =""; diyede yazılabilir. eğer if de yazdığınız satırlar TEKKKK ise süslü parantezleri kaldırabilirsiz.iki satır yazımışsa süslü parantez koyuyosn !!!
            //if (deger == "1")
            //{
            //    sonuc = "500.000 TL Kazandınız. Tebrikler...";
            //    Console.WriteLine("kutu seçildi");
            //}
            //else if (deger == "2")
            //    sonuc = "100.000 TL Kazandınız. Tebrikler...";
            //else if (deger == "3")
            //    sonuc = "10.000 TL Kazandınız. Tebrikler...";
            //else
            //    sonuc = "Malesef kazanamadınız. Çünkü böyle bir kutu yok..";

            //Console.WriteLine(sonuc);
            //Console.ReadLine(); 
            #endregion
                            
            string deneme;   // kullanılması için global olarak tanımlanmalı
            string x = "4";  // aşağıda küme parantezleri içerisinde olsa dahi 2 tane deneme değişkeni kullanılamaz! aşağıda deneme="SEYDA" yazarsak olur
            if (x == "3")
            {
                string y = "Yazılım Hocası";
                Console.WriteLine("Değer.. : " + x);
                Console.WriteLine(y);
            }
            Console.WriteLine(y); // y değişkenini burda kullanamıyorum çünkü y if e has değişken. if e özgü bir kavram
            Console.WriteLine(x); // x i kazabiliyorum

            {
                string deneme = "SEYDA";
            }
            Console.WriteLine(deneme); // denemeye erişemiyorum çünkü küme parantezleri içerisine yazımış. sadece o kümeye has.. bu değerler tanımlı olduğu yerde kullanılmalı..
        }

        void Test()
        {  // bir metodun içerisinde başka bir metodun değişkenleri kullanılamazzz!!!!. küme parantezi mantğıyla aynı!!!
            Console.WriteLine(deneme); // bulunamadı. bu deneme program bu class ın altında görünmes lazım diye düşünebiliriz.ama parantezlerden dolayı ulaşamıyorum
            Console.WriteLine(x);  // x e de ulaşamıyor
        }
    }
}

// class System.Console tam adresi
// console ifadesi bizim için class olarak nitelendirmiş olduğumuz bir sınıftır ve console olarak belirtmiş olduğumuz değer bir uygulamadır. biz buna console diyoruz 
// eğer bir sınıfın içerisinde bulunan metdolara ulaşmak istiyor isek . koyduğumuz taktirde console içerisinde bulunan değerler burada çıkacaktır
//WriteLine ı metod olarak adlandırıyoruz ve metodlar içerisine bazı değerler ve argümanlar alabiliyor
// metodlar bizim için sadece içerisine argüman değeri olarak veri alan ifadeler midir ? console.WriteLine(); yazsaydık imleç alt satırda yer alıyor. içerisindeki boşluk argümanını
// alıyor ve boşlukta bir karakter oldupundan dolayı bu şekilde alt satıra geçer..

    // Console nerden geliyor? bununda geldiği yer var mı?  using bloğundan geliyor.
    // usng bloğu bizim için program içerisinde kullanmış olduğumuz bazı metodlar, property yada argüman değerlerini içerisinde barındıran microsoft tarafından sunulan .NET FRAMEwork u
    // olarak belirtmiş olduğumuz kütüphane içerisinde bulunan bazı kodlamaları belirten tabirlerdir. Console sınıfı using System den geliyor. sadece console u kullandık. o yüzden diğer
    // lerini silebiliriz.
    // ctrl-space yaparsan kaybolan intellisense gelir 