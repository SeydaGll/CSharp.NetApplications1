using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun2Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // dışarıdaki tersten yazılmış bir metin dosyasını düzgün bir şekilde konsol uygulamasında yazdırmak
            // daha sonra bu yazılan düzgün metni başka bir metin dosyasına alarak yazdırmak.. yani tersten alınan bir metni düzgün olarak başka bir proje dosyasına yazın ??

            StreamReader oku = new StreamReader("SifreliMetin.txt");   // şifreli metini okuyabiliyosam   // path: yol
            StreamWriter yaz = new StreamWriter("SifresizMetin.txt");  // şifresiz metine yazabilirim.
            
            string satir = "";
            while (satir != null)
            {
                satir = oku.ReadLine();  // StreamReader nesnemin içerisinde bulunan değerim,oku adlı streamreader içerisinde bulunan metnın satır satır değerleri alınacaktır
                if (satir != null)  // bu satırları if blokları ile kontrol altına alıcam
                {
                    char[] metin = satir.ToCharArray();
                    Array.Reverse(metin);
                    Console.WriteLine(metin);  // kullanıcıya gösterdik
                    yaz.WriteLine(metin);  // başka bir txt ye yazdık. debug klasörümüz içerisinden görmüş olduk
                }
            }
            oku.Close();    
            yaz.Close();

        }
    }
}

