using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arraylist-list farkı
            //ArrayList arr = new ArrayList();
            //// ArrayList in içersi object olarak değerlendirildiğinden dolayı içerisine tüm değerler verilebilr.
            //arr.Add(123); // Add(object value) class,string,int,bloon verebilirsin. object ifadesi veritipi referans tiptir . c# da tüm değerler bu objectin içerisine verileblir.herşeyi kapsayan yapısı vardır. 
            //arr.Add("Şeyda");
            //arr.Add(true);  // çöp kutusu gibi herşeyi alabildi.

            ////ben veri güvenliği için object gibi tüm değerleri vermek yerine sadece int değerleri tutmak istiyorum. bunun için c# tarafında bizim için generic koleksiyonlar oluşturulmuştr

            //// Generic koleksiyonları görebilmemiz için using bloğuna eklememiz gereken şey var using System.Collections.Geeric

            //List<int> intList = new List<int>(); //generic kolaksiyonlar içerisinde bulunan List in genel tanımlama işlemidir.
            //intList.Add(123); // görüldüğü üzere ArrayList te de List te de Add metodu çıktı. yani Add metodlarını alındığı yer Arraylist ve List in aynı erdendir. bunlar birbiriyle gayet yakındır ve birbiriyle gayet olumludur
            //intList.Add(5); 
            #endregion               // yani ArrayList in yumuşatılmış hali List tir olarak  tanımlanabilir. Yani Array list içerisine herşeyi alabilirken List sayesinde istenilen veri tipine göre değerler yapılır. veri güvenliği sağlanır


            List<Otomobil> envanter = new List<Otomobil>();
            //oto.Add() // içerisine oto.Add(otomobil item ) istiyor o yüzden otomobil değeri üretelim

            Otomobil o1 = new Otomobil();
            o1.UreticiFirma = "BMW";
            o1.Model = "X6";
            o1.Renk = "Siyah";

            Otomobil o2 = new Otomobil();
            o2.UreticiFirma = "Toyota";
            o2.Model = "Corolla";
            o2.Renk = "Gri";

            envanter.Add(o1);
            envanter.Add(o2);

            // bunu ekrana nasıl yazdırırım..
            Console.WriteLine("Envanterdeki Araçlar");
            foreach (Otomobil item in envanter)
            {
                item.Yazdır();
            }

            //Telefon t1 = new Telefon();
            //t1.Model = "N97";
            //t1.Firma = "Nokia";

            //envanter.Add(t1); // bunun içerisine sadece otomobilin girilebiceğini telefonun alınamayacağına dair uyarı veriyor bundan dolayı bu şekilde bir veri girişi sağlayamayız.
            // envanter adı altında bulunan listede sadece Otomobiller olmak zorundadır. bu sayede içerideki veri güvenliğini sağlamış oluruz

            // sonraki dersimizde bir listeye nasıl tüm verileri ekleriz bunuda görücez. polimorfizim ile nasıl veri ekleriz onu görücez..

            // bu listenin içerisinden veri çağırmak...
            Console.WriteLine();
            Console.WriteLine("seçili olan değer");

            envanter[0].Yazdır(); // 0. indiste bulunanın giti metodunu çağırdı

            Console.WriteLine();
            Console.WriteLine(envanter[1].UreticiFirma); // bu şekilde istediğin takdirde tüm değerleri kullanabilirsin

            // Arraylist gibi bununda silme ve ekleme metodları ayndıır.
            // List in arraylistten ayrılan özelliğide içeriisne giren veri tipinin güvenliği söz konusudr . otomobil haric içerisine başka veri atılamaz.
            //arraylist çöp kutusudur ama list cam,plastik,metal olarak çöp kutuarına ayrılmıştır. buna göre metali metal kutusuna camı cam kutusuna atmak zorundayız.
            // bundan dolayıda List bizim için veri güvenliğini sağlamaktadir diyebiliriz.....
            Console.ReadLine();






        }
    }
}
