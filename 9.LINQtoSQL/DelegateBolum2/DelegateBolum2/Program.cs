using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBolum2
{
    class Program
    {

        // delegate ler bir sınıfın içerisinde tanımlanabilir

        public delegate bool Diziİslemleri(string s);  // delegelerin sadece metod gövdeleri olur. bunların içerisine herhangi bir kod değeri yazılmaz.. bunlar sadece bizim için metodların temsilcisidir. amcak hiçbir göreve dahil değildirler...bunları eventlerla görcez
                                                    // eventler : buton,textbox bunların üzerine tıklama yazılma veya rengini değiştirme gibi bazı olaylrı vardır ve bunlara event denir. eventlarda bizim için delegate yardımıyla ifade edilebilmektedirler
        public static string[] IslemMetodu(string[] dizi, Diziİslemleri fonksiyon)
        {
            ArrayList arr = new ArrayList();

            foreach (string item in dizi)
            {
                if (fonksiyon(item))
                {
                    arr.Add(item);
                }
            }

            return (string[])arr.ToArray(typeof(string));  // type of tipi verir. git bu tipte bir veri dönüşümü yapar artık elimde bir string dizi var 
        } // YANİ GLOBAL olarak bir metod yazdık. bu metodu kullanan herkes otomatik olarak delegate ide kullanmış olucak
        
        // şimdi delege kullanan başka bir metod oluşturalım
        //BİZİM İÇİN DELEGATE İN YAPISI NE ŞEKİLDE İSE KULLANILAN METODLARIN YAPISIDA O ŞEKİLDE OLMALIDIR. DELEGATE METODLARIN TEMSİLCİSİDİR....!!!!!!!!!!1***********
        public static bool KIleBaslayanlar(string s)
        {
            return s.StartsWith("K");
        }

        public static bool AIleBitenler(string s)
        {
            return s.EndsWith("a");
        }
        
        // DELEGATE BOOL DEĞER GÖNDERİYORSA BUNUN KULLANIMINA UYGUN OLAN METODLARDA GERİYE BOOL DEĞER GÖNDERMELİ VE İÇERİSİBE STRİNG DEĞER ALMALIDIRLAR..

        static void Main(string[] args) // temsilci
        {
            string[] sehirler = { "Konya", "Ankara", "Antalya", "Kahramanmaraş", "Kırşehir", "Kastamonu", "Ağrı" };

            Console.WriteLine("K harfi ile başlayan şehirler");
            string[] stringK = IslemMetodu(sehirler, KIleBaslayanlar);  // metodu  i kullanırken içerisine parametre almıyoruz çünkü delegate i kullandık aslında biz delegate te oluşturduk o parametreyi...!! 
            foreach (string item in stringK)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("A ile biten şehirler");

            string[] stringA = IslemMetodu(sehirler, AIleBitenler);
            foreach (string item in stringA)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
