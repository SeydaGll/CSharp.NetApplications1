using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface2
{
    class Ambar  // bu class bazı değerleri tutucak ve bu değerler benim için tüm ürünlerin içerisindeki değerleri barındırabilen bir koleksiyon değeri taşıcak. ve bunun içersine çağırma işlemi yaptığım zaman da bazı koleksiyonları kullanıcam
    {
        //FIFO(First IN first Out) ilk giren ilk çıkan mantığıyla çalışan bir koleksiyon. queue adı altında çalışan koleksiyon ne işe yarar?
        // biz buraya yeni bir ürün eklediğimiz zaman bu listenin altlarına eklenecektir. ve bunu bulmak zor olucak. ancak bizim için bu koleksiyonunn içerisine ilk eklenenle son eklenen 
        // değerini çağırmak için direk olarak metodlar kullanıcaz ve bu sayede bi karmaşıklığı aşmış olucaz.. git ve bu class ı kullan diyoruz..

        private Queue<IUrun> envanter { get; set; } // her çağırdığımda üretmemi istediğinden dolayı bunu constractrın içerisinde üretmek istiyorum.bundan dolayı bunun ismini bir propertye verelim
        public Ambar()
        {
            envanter = new Queue<IUrun>();  // sürekli üretmemek için ctr kullandık. git envanter adı altında bulunan property nin içerisine bazı değerler yaz .. yazacağın değerler  ise yeni bir koleksiyon
        }

        public IUrun EskiDegeriOku() // IUrun tarzında bir değişken tanımla.git envanter adı altında bulunan property nin içrsinden bana ilk değerimi oku. çünkü bunun işlemi ilk giren işk çıkan tabiriyle
        {
            IUrun eskiDeger = envanter.First();
            return eskiDeger;
            
        }

        public IUrun YeniDegeriGonder()
        {
            IUrun YeniDeger = envanter.Last();
            return YeniDeger;
        }

        // peki envanter in ierisine veri girisi nasıl yapıcam.bunun içinde metod yazıp veri girişi yapıcaz. yani nasıl ArrayList ve List in Add metodu varsa bizimde Ekle diye metodumuz olsun
        public void Ekle(IUrun eklenecekUrun)
        {
            envanter.Enqueue(eklenecekUrun);
        }
    }
}
