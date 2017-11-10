using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    class Urun
    {
        public int UrunNo { get; set; }
       
        public virtual void Yazdır() // sanal ol. ben bunun üzerine müdahale edebilirim
        {
            Console.WriteLine("Ürün Numarası...:{0}",UrunNo);
        }
    }
}
