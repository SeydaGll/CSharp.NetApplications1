using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaOrnek2
{
    class Program
    {
        //public delegate bool StringFonksiyonlar<T>(T s); // generic koleksiyon olduğunu söyledik..
        //public static string[] IslemMetotStr(string[] dizi, StringFonksiyonlar<string> fonksiyon) // genericdelegate yazdık. generic değerler ile de lambda kullanılabilir.
        //{
        //    ArrayList arr = new ArrayList();
        //    foreach (string item in dizi)
        //    {
        //        if (fonksiyon(item))
        //        {
        //            arr.Add(item);
        //        }
        //    }

        //    return (string[])arr.ToArray(typeof(string));
        //}

        public static string[] İslemMetotGenel(string[] dizi, Func<string, bool> fonk)  // Func ile bir delegate yazmada bir delegate kullanabilriz... 
        {

          ArrayList arr = new ArrayList();
            foreach (string item in dizi)
            {
                if (fonk(item))
                {
                    arr.Add(item);
                }
            }

            return (string[]) arr.ToArray(typeof(string));

        }




    static void Main(string[] args)
    {
        string[] sehirler = { "Ankara", "Adıyaman", "Konya", "Kayseri", "Ağrı", "Kırşehir", "İzmir" };
            //string[] strA = IslemMetotStr(sehirler, (s => s.StartsWith("A")));

            string[] strB = İslemMetotGenel(sehirler, (s => s.EndsWith("r")));
        foreach (string item in strB)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }

}
}


