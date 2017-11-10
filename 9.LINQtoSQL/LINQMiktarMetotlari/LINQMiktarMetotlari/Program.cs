using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMiktarMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilarim = { 40, 35, 98, 15, 148, 36, 19, 496, 25, 79, 19, 80 };

            //1.işlem // yüzden küçük değerleri yazdıran bir sorgu. ya any kullanırsın yda all.
            //var deger = sayilarim.Any(s=>s < 100);  //any() olarak kullanırsan true cevabı döner.yani bizim için içerisinde bir sayı olduğunu onayladı
            //s olarak değerlendirilen bir verim var. yani bu benim için dizinin içerisinde gezdiğim veri değerleri.any(s=>s <100) ile true cevabını aldık

            // any ve all olayını ve veya ya benzetebiliriz.eğer ki any kullanılmış ise bunun içerisinde 100 den küçük var ise true dur.ama 100 den büyük var ise bu beni ilgilendirmez.sadece benim işime 100 den küçük olan değerler yaramaktadır
            // all  metodu eğer ben 1000 den küçük olan değerleri tespit et diyorsam eğerki 1001 rakamı var ise burada false dönecektir. benim verdiğim bu değer üst noktadır. ben bundan küçük değerleri aramaktayım


            //2.işlem
            //var deger = sayilarim.All(s => s < 1000); // false döner. 100 den küçük sayı var mı?. 1000 deseydim true dönerdi

            //3.işlem  // içeriinde 19 elemanı var mı?
            //var deger = sayilarim.Contains(19); // bunar bool değer dönderir

            //4.işlem  // dizinin eleman sayıları
            //var deger = sayilarim.Count();

            //5.işlem  // dizi içerisinde değereri topla
            //var deger = sayilarim.Sum();  // bunu kullanmasaydık bizim için for döngüsüyle tüm elemanları gez,+ = operatörüyle yardımıyla tamamen topla dicektik. böyle bir extension metodumuz old için yapmak zorunda kalmadık

            //6.işlem
            //var deger = sayilarim.Min();

            //7.işlem
            //var deger = sayilarim.Max();

            //8.işlem
            //var deger = sayilarim.Average();

            //9.işlem
            //var deger = sayilarim.First();  // sayilarim[0] yapıcaktık

            //10.işlem
            //var deger = sayilarim.Last();

            //11.işlem  // ilk baştan başladı ve bizim için 60 dan büyük olan ilk sayı dğerini getirdi..cevap 98 gelir.baştan başlar ve kritere uygun olan ilk elemanı getirir
            //var deger = sayilarim.FirstOrDefault(o => o > 60);  // bir şart ile ilk elemanı belirle !!!

            //12.işlem
            //var deger = sayilarim.LastOrDefault(o => o > 90);

            //13.işlem  biraz karmaşık. git bana kriterime uygun olan tek bir tane değer getir.. burada tek olması önemli başka hiçbir şartı yok
            //var deger = sayilarim.Single(s => s > 148);  // 148 de büyük olan tek sayı 496
            //var deger = sayilarim.Single(s => s > 90); // hata verir. 1 den fazla değer içeiri

            //14.işlem
            //var deger = sayilarim.SingleOrDefault(s => s > 496);  //en büyük değer budur o yüzden 0 verdi

            //15.işlem..bir sayı değeri blirle ama bunun içerisine bi döngüymüş gibi bir kontrol mekanizması kur
            //var deger = sayilarim.Aggregate(100, (o, p) => o > p ? o : p);  //şart söylüyorum git 100 den başla. benden int değer yazmamı istiyor o ve p değeri tanımla dedim. 2 tane deger tanımladım. gt benim için o değerinin p den büyük olması iste . burada o değeri bizim için buradaki gezilen tek tek değerlerdir. daha sonra bizim için o değeri büyük mü p değerinden. sonra bu şartı yazdıktan sonra ? ile buradki if işlemini yazıyorum. o nun p ile olan aralığını gez ve benim için bir cevap ver.daha sonra bu işlemin içerisinde arama işlmei yapılacak ve o değerinde büyük olan her değer bizim alınacaktır
            // bir döngü yardımıyla max sayıyı bulmuş olduk. döngü mantığı..

            //16.işlem
            var deger = sayilarim.Aggregate(0, (o, p) => o += p);




            Console.WriteLine(deger.ToString());

            Console.ReadLine();
        }
    }
}
