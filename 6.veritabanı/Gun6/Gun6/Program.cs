using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun6
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
// foreign key yani tabloları ilişkilendirmek istiyoruz . bu ne demek ? bizim için iki tablonun birleştirilmesi ve bu tabloların ilişkilendirilmesinden söz eden bir kavramdır. bunu 
// c# içerisinde bir polimorfizim yöntemiyle yda inheritence(kalıtım) yöntemiyle ilişkilendirebilirsin. yani müşterilerin içerisinde bulunan değerler satışların içerisinde görülebiliyor
// sa ve müşteriler tablosu satışlar tablosuna müdahale edebiliyorsa bunların arasında bir ilişki vardır. bunun için diyebiliriz ki istediğiniz takdirde müşteriId değerine tıklayıp 
// sürükleyebilirsin.
//Müşterilerin içerisine girilen bir değer direk olarak satışların içerisine de girilebilecektir.Böylelikle tablolarda bağımsızlık olayı ortadan kalkacaktır
// sorgu sonucunda tablodaki değer yoksa hata vermez, null değerini verir.