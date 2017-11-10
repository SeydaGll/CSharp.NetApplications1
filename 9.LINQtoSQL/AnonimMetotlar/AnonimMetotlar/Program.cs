using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] sehirler = {"Konya","Kastamonu","Ankara","Adıyaman","Adana","Ağrı"};
            // Anonim metotlar

            //Diziİslemleri delege = delegate (string s) { return s.StartsWith("A"); };  // metodun kısa hali..//anonim metot

            //string[] stringA = İslemMetot(sehirler, delege); // delege yada bu delege ye uygun bir metot istemektedir..metotmuş gibi işlem yapıcak..
            // herhangi bir metot yazmadan işlemler yaptık..anonşm bir metot kullandık

            string[] stringA = İslemMetot(sehirler, delegate (string s) { return s.EndsWith("a"); }); // tek satır kod ile yazdık..anonim



            foreach (string item in stringA)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        public delegate bool Diziİslemleri(string s);

        public static string[] İslemMetot(string[] dizi, Diziİslemleri fonk)
        {
            // bu metot kullanıldığı taktirde içerisine string bir dizi ve delegate istiyor.buradaki metodlar direk olarak Diziİslemleri adı altında bulunan buradaki delegate in üzerinden buradki fonksiyonun içerisine verilecek
            ArrayList arr = new ArrayList();

            foreach (string item in dizi)
            {
                if (fonk(item))  //dizilerin her bir satırı bizim için item olarak değerlendirlir.delegate bana bool değer dönüyor .<eğer buradaki değer treu ise...
                {
                    arr.Add(item);  // senin gezmekte olduğun satır değerini gel buradaki dizinin içerisine aktar
                }
            }

            return (string[])arr.ToArray(typeof(string));    // array listin içerisindeki verileri tamamen görebilmem için bunu bir diziye çevirmem gerekir..)//typeof tip bulma değeridir.

            
        }
    }
}
  /// e