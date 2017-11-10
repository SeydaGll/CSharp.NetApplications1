using System;


namespace Gun1Odev  // derlendiğinde Gun1Odev.exe çıktısı vericek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Gun1Ode.exe adı altında 
             * 1) bu proje çalıştırıldığında "Lütfen Kullanıcı ID si giriniz ve Enter Tuşuna Basınız..." adı altında metin yazıcak
             * 2) bizim için dışardan girilen kullanıcı ID si eğer doğru ise  bizim için  "Başarılı bir şekilde giriş yaptınız ... Teşekkür ederiz.. " uyarısı versin
             * 3) Bu uyarı yeşil renkte olsun
             * 4) yanlış uygulama değeri girildiyse.."Hatalı Giriş.... Lütfen Tekrar Deneyiniz...yazını kırmızı renkte ve bip sesiyle göstersin
             */
            Console.WriteLine("Lütfen Kullanıcı ID si Giriniz ve Enter Tuşuna Basınız...");
            string ID = Console.ReadLine();
            string sonuc;
            if (ID=="2017 1453 57")  // içerisi true ise
            {
                sonuc = "Başarılı bir şekilde giriş yaptınız... Teşekkür ederiz";
                Console.ForegroundColor = ConsoleColor.DarkGreen;  // darkgreen gibi değerler enum değerlerdir . 
            }else
            {
                sonuc ="Hatalı Giriş... Lütfen Tekrar deneyiniz...";
                Console.Beep();    //   Console.WriteLine("\a") da kullanabiliriz.
                Console.BackgroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
