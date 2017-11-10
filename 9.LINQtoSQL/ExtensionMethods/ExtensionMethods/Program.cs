using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class Program  //static olmalı..
    {
        static void Main(string[] args)
        {
            //int sayi = 123;
            //SayiYazdir(sayi);

            // amacım burda metd kullanmadan direk int bir değeri yazdırmak istiyorum. yani değişkenin ismini yazıp daha sonra noktaya bastiğim taktirde buradaki metodlar sayesinde bir metodun olması ve bu metodlar sayesinde ekrana değerinin yazdırılmasi........

            int sayi1 = 147;
            //sayi1.  // amacım sayi1. dediğim taktirde sayıyazdır metodunun çıkması...
            sayi1.Yazdir();  //* içerisine parametre istemediğini görebiliriz çünkü this keywordü sayesinde buradaki metodum int değere yapıştı. bundan dolayı yapışkan metod. artık tüm int değerlerde artık yazdır metodunu kullanabilirm..

            int sayi2 = 236;
            sayi2.Yazdir();  // artık tüm int değerler de bu metodu kullanabilirm. yani direk olrak metodu yazıp bazı parametre değerleri vermek yerine tüm int değerlere yapıştırmak benim işimi kolaylaştırıcaktır..

            string metin = "ilker ışık";
            metin.MetinBuyut();

            int sayi3 = 10;
            sayi3.Arttir().Azalt().CarpmaIslemi().Fark().Yazdir();  // içe içe metod kullanma... Yazdır() dan sonra nokta koyulunca artık void den dolayı bir değer önmediğinden işlme burada sonlanır

            Console.ReadLine();
        }

        public static int Arttir(this int a)
        {
            return a++;
        }

        public static int Azalt(this int a)
        {
            return a--;
        }

        public static int CarpmaIslemi(this int a)
        {
            return a*10;
        }

        public static int Fark(this int a)
        {
            return a-2;
        }

        public static void MetinBuyut(this string metin)
        {
            Console.WriteLine(metin.ToUpper());
        }

        public static void Yazdir (this int a)  // this ile keyword ü ekleriz. ama program classının altı çiziliyor.. benim için buradaki extension metodların üst classı olarak değerlendirilen sahibide static olmak zorundadır..
        {
            Console.WriteLine("SAYİ değerim ...:"+a.ToString());
        }
        //static void SayiYazdir(int sayi)
        //{
        //    Console.WriteLine("Sayı değerim....:"+sayi.ToString());
        //}

        // EXTENSİON METHOD YAZMAK
        /* 1) CLASS STATİK OLMALI
         * 2) METOD STATİK OLMALI
         * 3) METOD PARAMETRE OLARAK 'THİS' ALMALI */
    }
}
