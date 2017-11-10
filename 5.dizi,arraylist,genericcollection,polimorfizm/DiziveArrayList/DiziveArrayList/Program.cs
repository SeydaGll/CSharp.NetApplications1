using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DiziveArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region diziler
            ////Otomobil adıı altında dizi tanımlanabilir mi?
            //Otomobil[] o = new Otomobil[3]; // kendi oluşturduğumuz class larıda biz dizi olarak tanımlayabiliri.bu otomobil adı altında bulunan dizinin içersinde 3 tane otomobil classı vardır
            //Otomobil o1 = new Otomobil();  // bunlar class n içersinde . ama bunların yerine ArrayList kullanılan bir koleksiyon anltılcak 
            //Otomobil o2 = new Otomobil();
            //Otomobil o3 = new Otomobil();

            //o1.UreticiFirma = "BMW";
            //o1.Model = "740";
            //o1.Renk = "Siyah";
            //o1.KM = 12345;
            //o1.Yil = 2011;

            //o2.UreticiFirma = "Renault";
            //o2.Model = "Megane";
            //o2.Renk = "Gri";
            //o2.KM = 34567;
            //o2.Yil = 2009;

            //o3.UreticiFirma = "Honda";
            //o3.Model = "X";
            //o3.Renk = "Beyaz";
            //o3.KM = 2345;
            //o3.Yil = 2006;

            //// bir tane daha üretirsek bu otomobil class ının içersinde bu otomobil class ı verilemez

            //o[0] = o1;
            //o[1] = o2;
            //o[2] = o3;
            //// o[4] = o1;  burda hata veriyor bu bizim için bir kısıtlamadır

            //Console.WriteLine("Otomobil Envanterindeki Değerler");
            //for (int i = 0; i < 3; i++)
            //{
            //    o[i].Yazdır();
            //}

            //// for döngüsüyle birden fazla değeri aldık. şimdi bir tanesinin değerini alalım

            //Console.WriteLine(); // boşluk bıraklaım böylece
            //Console.WriteLine("1. sıradaki araç..");
            //o1.Yazdır();

            ///* bu şekilde diyelim ki yeni bir araç daha eklemek istiyoruz.yani otomobil4. ama bu içersinde 3 tane otomobil barındıran bir dizi için mümkün değil. dyelim li eklemek 
            // yerine reanult değerini silicem. buradan değerini silmem için benim için tampon bir dizi tanımlamam bu diizye değerleri aktarmam daha sonrasında bir sürü işle yapmam gerekice
            // . bundan dolayı bizim bazı koleksiyonlar avantaj durumundadır*/ 
            #endregion

            #region ArrayList

            ArrayList otomobilDizi = new ArrayList(); // içersine herhangi bir rakam yazmıyorum.ram doluncaya kadar istediğini yazabilirsin.
                                                      //biliyoruz ki bu bizim için object değeri almaktadır ve object aldığından dolayıda referans bir tipindedir ve yani bu
                                                      // arraylist içindeki bilgiler direk ram üzerine yazılır..
            Otomobil o1 = new Otomobil();
            o1.UreticiFirma = "BMW";
            o1.Model = "740";  // bu durum ürettiğim otobile değer atamaktan öte birşey değil. bunu yapmam gerekiyor
            o1.Renk = "Siyah";
            o1.KM = 12345;
            o1.Yil = 2011;

            Otomobil o2 = new Otomobil();
            o2.UreticiFirma = "Renault";
            o2.Model = "Megane";
            o2.Renk = "Gri";
            o2.KM = 34567;
            o2.Yil = 2009;

            Otomobil o3 = new Otomobil();
            o3.UreticiFirma = "Honda";
            o3.Model = "X";
            o3.Renk = "Beyaz";
            o3.KM = 2345;
            o3.Yil = 2006;

            // sıra geldi bunları bizim için dizinin içeriğine vermeye...
            otomobilDizi.Add(o1); // otomobilDizimin içereisine benim değerleri yaz dicem
            otomobilDizi.Add(o2); // bunlardan istediğim kadar yazabilrim çünkü herhagi bir rakam ve değer belirtmedim.
            otomobilDizi.Add(o3);

            Console.WriteLine("Araba değerlerim");
            // içersimdeki değerleri foreach ile alıyoruz
            foreach (object item in otomobilDizi)  // otomobilDizinin içersindeki otomobil değerlerini araacaktır
            {
                // item. // dediğim zaman içersindeki değerleri göremiyoruz ama Yazdır metodunu kullanmam gerekiyor. bunun için otomobil sınıfından üretiyorum
                Otomobil araba = (Otomobil)item; // otomobil i new keyword ü ile ürettiğim zaman arabanın içersindekileri görebiliyorum ama benim bu item ın içerisinde bulunan bazı değerleri görmem lazım.bunun için Otomobil tipinden araba değerini tanımlıyorum ve git bunun içersine item değerini yaz.bunu yazmam için ediyorum. item i alıcak ve arabanın içersine aktaracak
                araba.Yazdır();  // böylelikle içersindeki object değerini okuyabldim 
               
            }
            // bunun içersinden bir tane değeri almak
            Console.WriteLine();
            Console.WriteLine("Seçili Olan Eleman");

            Otomobil seciliDeger = (Otomobil)otomobilDizi[1]; // 1. değeri alıcak ve secildeğerin içersine aktaracak
            seciliDeger.Yazdır();

            // yeni bir değer eklemek istiyorsam
            Console.WriteLine("Yeni Araba Değeri Ekliyorum");
            Otomobil o4 = new Otomobil();
            o4.UreticiFirma = "Toyota";
            o4.Model = "Corolla";
            o4.Renk = "Siyah";
            o4.Yil = 2004;
            o4.KM = 10000;

            otomobilDizi.Add(o4);  // bu sayede değer eklemiş oluyorum. kısıtlamam yok
            // değer nereye eklenmiş
            Otomobil yeniDeger = (Otomobil)otomobilDizi[3];
            yeniDeger.Yazdır();

            // arasına değer eklemek istiyorsam
            Console.WriteLine();
            Console.WriteLine("2.satıra değer ekle");
            Otomobil o5 = new Otomobil();
            o5.UreticiFirma = "Fiat";
            o5.Model = "X";
            o5.Renk = "Siyah";
            o5.Yil = 2004;
            o5.KM = 10000;
            otomobilDizi.Insert(2, o5); // böylece araya değer ekledi otomatik

            // silme işlemi
            Console.WriteLine("Silme İşlemi başlıyor..isme göre");
            Otomobil otoSil = (Otomobil)otomobilDizi[1];
            otomobilDizi.Remove(otoSil); // böylece silme işlemini bir isme göre yapablrsiniz 

            Console.WriteLine("Silme işlemi 2 indis değerine göre");
            otomobilDizi.RemoveAt(0);  // indise göre siler

            Console.WriteLine("Araba Listemde Kaç Tane Otomobil Kayıtlı??");
            Console.WriteLine(otomobilDizi.Count+ " Adet otomobil bulunmaktadır");  // içerisinde bulunan eleman sayısını verir

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Mevcut olan otomobiller");

            foreach (object item in otomobilDizi)
            {
                Otomobil araba = (Otomobil)item;
                araba.Yazdır();
            }

            // işlem tamamlandı
            Console.WriteLine("işlem tamamlandı");

            Console.WriteLine("Telefon Sınıfı İşlneiyor");
            Telefon t1 = new Telefon();
            t1.UreticiFirma = "Nokia";
            t1.Marka = "N97";
            t1.Fiyat = "2000 TL";

            // BUNU Otomobl adı altındaki diziye kaydedebilir miyim ? hata olucak mı? çünkü biliyorum ki bir string diziye bir int değer veremem. elmayı elma kasasına armutu armut kasasına
            // koyman gerekir. ancak arraylist için böyle bir sorun var mıdır ?

            otomobilDizi.Add(t1);

            foreach (object item in otomobilDizi)
            {
                Otomobil arabam = (Otomobil)item; // Otomobil içersindeki veriye göre git item ı cast et..
                arabam.Yazdır();
            }
            // hata verdi.. bunun içersinde bir telefon değeri var ve bunnu otomobil değerine cast ettiğimden dolayı hata verdi. cast olayında bulunan br hata var. sen Telefon
            // classı na ait olan bir veriyi Otomobil değeri olarak cast edemezsin.içeriğini göremezsin..hangi tiptense ona göre değerlendirmek daha doğrudur.. 

            // sonraki derste bunu nasıl aşarız onu görcez.. 
            // Generic sınıflar vardır ve tipe göre bir dizi tanımlayabilcez...



            #endregion

            Console.ReadLine();



        }
    }
}
