using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class MotorMontaj
    {
        public Araba ArabaOlustur(string model, Motor motorTipi)
        {
            Araba myCar = new Araba();
            myCar.model = model;
            myCar.Motor = motorTipi;
            return myCar;
        }
    }
}
