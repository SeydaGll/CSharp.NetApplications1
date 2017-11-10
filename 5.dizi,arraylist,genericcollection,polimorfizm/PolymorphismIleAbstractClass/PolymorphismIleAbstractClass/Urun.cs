using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleAbstractClass
{
    abstract class Urun // artık soyut oldu
    {
        public int UrunNo { get; set; } // nonabstract bir propery

        public void IslemYap()  // nonabstract bir metod
        {
            Console.WriteLine(UrunNo);
        }

        //public abstract void Yazdir()  // böyle bir metod yazarsak hata verir.. siz eğer abstarct bir sınıfta abstarct bir metod yazıyorsanız gövdesini oluşturamazsınız
        //{                       // yazıp bırakmnız lazım. gövdesi miraz alan sınıf tarafından OLUŞTURULUR.....
        //    Console.WriteLine(UrunNo);
        //}

        public abstract void Yazdır(); // abstarct olan bir metod abstarct olmayan bir sınıfın içinde TANIMLANAMAZ.. abstract-overrride . abstarct sınıfın içersinde virtual kullanılmaz
                                            // çünkü abstact diyerek  zaten soyut yapmış oldum



    }
}
// eper ben bu sınıfı static yapsaydım içindeki tüm varlıklarda static olmak zorundaydı. bunun içerisinde abstract olan yada abstract olmayan değerler diye ikiye ayrılcak 