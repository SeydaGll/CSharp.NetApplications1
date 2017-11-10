using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIleMetinOkuma
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 10;
            //while (sayi<100)
            //{
            //    Console.WriteLine(sayi);
            //    sayi += 5;
            //}
           
            // Metin belgesinden değer okumak için bir sınıfımız var...StreamReader
            StreamReader oku = new StreamReader("Metin.txt");  // metin e sağ tıkla property den copy to output directory bizim için bu projenin çalıştırıldığı ortama gidip bu dosyayı 
                                                                // kopyalayım mı diyerek bir ifade var bunu copy if newer yap yani dosya yoksa git oluştur gibi bir uyarı verilcek.. 
            string satir="";            // böylelikle proje çalışır çalışmaz bin klasörüne kopyalancak ve değeri ordan okucaktır .yada stream den tam uzantısını yazabilrsin ama önerilmez.
            while (satir != null)  // eğer satir eşit değilse null a demek istedik.. != olumsuzluk. null :: boşluk anlmına gelen tabirdir
            {
                satir = oku.ReadLine();  // readline satır satır DEĞERİ alarak veri okumak konusunda görevli olan bir metod.bu StreamReader a ait bir metod diğeri ise Console a ait bir metoddu ama ikisininde mantığı AYNI
                if (satir != null) //koşul yazıyoruz
                Console.WriteLine(satir);
            }
            oku.Close();  // StreamReader ı kapama işlemi yapmamız lazım

            Console.ReadLine();
        }// metin içerisindeki değeri bir bir alıcak ve ekrana yazıcak.. 
    }
}
// copy to output directory (çıktı dizinine kopyala) yı copy if newer yapman lazım yoksa dosyayı belirtilen yerde bulamadığına dair hata verir    .
// bin in içerisinde debug dosyasında bulunamadığına dair hata verir. normalde proje dosyamızın içerisinde oluşturduğumuz text bulunur. ama debug da yok.
// normalde debug daki kopyadan alarak işlem yapar.prjein çalıştırıldığı ortama gidip bu dosyayı kopyalayım mı diyerekten bir ifade. bunu dosya yoksa git oluştur dicem.değeri 
// bin den okuyacaktır....

// StreamReader oku = new StreamReader("Metin.txt"); bir new keyword ü ile üretilen class yada yapı bunun içerisinde costracture(ctro ) diye bir yapı vardır ve üretildiğitaktirde
// ilk çalışacak yapıdır. örneğin Main () metodu proje çalıştırılır çalıştırılmaz devreye giriyor. aynı şekilde. ben buraya string bir yol yazdığım taktirde bu ifadem üretilir
// üreilmez yolu ile birlikte üretilecektir yani derlenir derlemez buradaki yola göre işlem yapıcaktır

