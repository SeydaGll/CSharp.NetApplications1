using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface
{
    class Telefon:IYazdır
    {
        public string Model { get; set; }
        public string Firma { get; set; }

        public void Yazdir()
        {
            Console.WriteLine(Firma + "  " + Model);

        }
        //public void Yazdir()
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
