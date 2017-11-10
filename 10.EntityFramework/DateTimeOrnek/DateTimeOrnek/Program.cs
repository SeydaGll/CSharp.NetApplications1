using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime zaman = DateTime.Now;

            //Console.WriteLine(zaman.ToShortTimeString());  // kısa saat değeri 15:20   saat dakika
            //Console.WriteLine(zaman.ToLongTimeString());  // uzun ssat deeği 15:11:39   saat dakika saniye

            //Console.WriteLine(zaman.ToShortDateString()); //10.10.2017
            //Console.WriteLine(zaman.ToLongDateString());   //10 Ekim 2017 Salı

            //DateTime zaman = new DateTime(2017, 10, 10);
            //Console.WriteLine(zaman.ToString());   // 10.10.2017 00:00:00  zamanı 0 vermesinin nedeni bizim zaman değerini vermemizden dolayıdır

            //DateTime zaman = new DateTime(2017, 10, 10, 15, 17, 20);
            //Console.WriteLine(zaman);   10.10.2017 15:17:20

            //DateTime zaman = new DateTime(2017, 10, 10, 15, 17, 20);
            //Console.WriteLine(zaman.Year);  //2017

            //DateTime zaman = DateTime.Now;
            //Console.WriteLine(zaman.Millisecond);

            //DateTime zaman = DateTime.Now;
            //Console.WriteLine(zaman);  //10.10.2017 15:25:55
            //zaman = zaman.AddDays(20);  // 30.10.2017 15:26:10....tarihimize 20 gün ekleyip gösterir........
            //Console.WriteLine(zaman);
            //zaman = zaman.AddDays(20).AddHours(-36);  //29.10.2017 03:28:09
            //Console.WriteLine(zaman);
            //zaman = zaman.AddDays(20).AddHours(-36).AddMinutes(20).AddDays(20).AddYears(5);
            //Console.WriteLine(zaman);

            //DateTime dogumGunum = DateTime.Parse("01/05/1991");
            //Console.WriteLine(dogumGunum.ToShortDateString());  //1.5.1991

            //TimeSpan yasim = DateTime.Now.Subtract(dogumGunum);  //subtract çıkarma demektir. yani şuanki tarihten içerisine verdiğim tarihi çıkarıcak ve yaşım göstericek
            //Console.WriteLine(yasim.TotalDays.ToString()); // 9659,64896105432 gündür yaşıyorum....

            //güvenlik işlemi.. girilen tarih zaman değerlerini tryparse ile kontrol edebiliriz...
            //DateTime zaman;
            //if (DateTime.TryParse("10/10/2017",out zaman))    //tryparse bool değer döner yani true yada false döner. ama out ile bir datetime tipide almış olucam.. değiştirmeni isteiğim değer buradaki zaman değeri 
            //{                           //out değeri vermiş olduğumuz değer ile birlkte değişiklik yapacak olan bir keyworddür. 
            //    Console.WriteLine(zaman);
            //}
            //else
            //{
            //    Console.WriteLine("zaman değeri hatalı");
            //}



            DateTime zaman;   //yazılan zaman değeri yanlışşş....
            if (DateTime.TryParse("10(10)2017", out zaman))    //tryparse bool değer döner yani true yada false döner. ama out ile bir datetime tipide almış olucam.. değiştirmeni isteiğim değer buradaki zaman değeri 
            {                           //out değeri vermiş olduğumuz değer ile birlkte değişiklik yapacak olan bir keyworddür. 
                Console.WriteLine(zaman);
            }
            else
            {
                Console.WriteLine("zaman değeri hatalı");
            }



            Console.ReadLine();


        }
    }
}
