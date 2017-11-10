using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Bilgisayar : Deneme2, IYazdir, IUrun,IDeneme
    {
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void DegerYaz()
        {
            throw new NotImplementedException();
        }

        public void DepolananDegeriOku()
        {
            throw new NotImplementedException();
        }

        public void Yazdir()
        {
            throw new NotImplementedException();
        }
    }
}
