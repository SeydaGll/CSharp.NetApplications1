using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIleInterface
{
    public interface IYazdır  // yapısı lass a benzer. içerisine birden falza değeri miras alabilir.bu sadece interface lerde geçerlidir
    {
        void Yazdir(); // bir interface in içerisinde bir değer tanımlanırken access modifiers kullanılmaz..değeri private olmak zorundadır..private yazarsan da hata verir.
                       //interface de sadece kod yapısı bulunmalıdır. bunun içeriği bu interface ı miras alan yer tarafından yapılmalıdır
       //interface i miras alıyosun benim dediğimi yapmak zorundasın demek istiyoruz..
    }
}
