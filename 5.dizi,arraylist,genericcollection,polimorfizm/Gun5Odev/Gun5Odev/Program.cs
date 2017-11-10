using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun5Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Mutant> mutantlar = new List<Mutant>();  //generic koleksiyonumun içerisinde buluna List i kllancam.
            FizikselMutant fiziksel = new FizikselMutant();
            fiziksel.KodAdi = "Demir Adam";
            fiziksel.Guc = 120;
            fiziksel.IQ = 60;
            fiziksel.Bolum = 7;
            mutantlar.Add(fiziksel);
            
            RuhsalMutant ruhsal = new RuhsalMutant();
            ruhsal.KodAdi = "Yağmur Kızı";
            ruhsal.GucKullanimMiktari = 20;
            ruhsal.IQ = 100;
            ruhsal.Bolum = 5;
            mutantlar.Add(ruhsal); // mutantı kalıtım yaptığından artık suhsalmutant bir mutanttır
            
            TemelMutant temel = new TemelMutant();
            temel.KodAdi = "Deniz Kızı";
            temel.Bolum = 9;
            temel.Bolge = 6;
            mutantlar.Add(temel);*/

            // yeni bir generic koleksiyon tanımlayalım.. bu şekilde bir kısaltma ile koleksiyonların içerisine veri girebilirin.kod kalabalığı gider. add yapmak zorunda kalmadık
            List<Mutant> mutantlar = new List<Mutant>()
            {
                new RuhsalMutant(){ KodAdi="Yağmur Kızı", IQ= 100, Bolum=5, GucKullanimMiktari=20  },
                new FizikselMutant(){KodAdi="Demir Adam", IQ=40, Guc=300, Bolum=3},
                new TemelMutant(){ KodAdi="Deniz Kızı", Bolge=6, Bolum=11}
            };





            foreach (Mutant item in mutantlar)
            {
                item.GorunumBilgisi(); // git bana gorunum bilgisini getir ve böylece sadece bir metod sayesinde tüm class ların içerisindeki verileri almış olucam
            }
            
            Console.ReadLine();

        }
    }
}
// ilk başta IGoruntu adı altındaki interface i sonra mutantı oluşturalım sonra diğer sınıfları oluşturalım..