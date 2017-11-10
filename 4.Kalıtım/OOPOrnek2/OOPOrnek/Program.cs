using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Otobüs otobüs = new Otobüs();
            //otobüs.Baslat();

            //BenimRenklerim.Lacivert;  // Lacivert değerini alır.. bunlar herhangi bir değere verilmek durumundadır.. tek başına kullanılamaz.bunları bazı property lerle kullanmak
            //            // işimizi kolaylaştıracaktır



            Otobüs o = new Otobüs();
            o.UreticiFirma = UreticiFirmalarım.BMW; // artık üretici firmanın değeri BMW olarak değerlendirildi
            Console.WriteLine(o.UreticiFirma); // buradaki enum değerini gitti bizim için stringe çevirdi ve bunu işleme tabi tuttu


            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    // bir enum nemaespace altına yazılır..classa bir enum yazılmaaz..
    enum BenimRenklerim  // türkçeye uyabilirsiniz
    {
        Sarı,
        mavi,
        Lacivert,
        Kırmızı

    }
}
