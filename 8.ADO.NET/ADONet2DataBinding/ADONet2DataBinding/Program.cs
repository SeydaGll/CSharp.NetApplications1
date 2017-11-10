using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet2DataBinding
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// event nedir ???? butona tıklama işleminin sonrasında gerçekleşen olaylara event denir... iki parantez içerisine yazılan kodlar event için bir olay  niteliğindedir.
//tıklamasının sonrasında burdaaki kodlar aktif olarak çalışıcaktır..

    // form1_load değeri var bu değer  formun içerisinde bulunan bir event diyebiliriz.
    // form yüklenirken müşteriler  tablosunun içerisi doldurulyor. daha sonra datagrid içerisine buradaki veriler aktarılıor. bu gibi işlemler bu gibi eventler sayesinde yapılır.

    // butona tıkladığıda buradaki verileri kaydetmek..
    // this.  bu demek buradan kastımızform1 in kendisidir.this ile ulaşabileceğimiz yerler butondır,datagriddir,dataset,adaptör olarak değerlendirilir
    // buradaki bulunandeğerleri bizim kontrolümüze sunucaktır