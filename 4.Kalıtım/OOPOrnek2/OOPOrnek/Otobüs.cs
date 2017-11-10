using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Otobüs : Araba
    {
        public override void Baslat()  //override: geçersiz kıl  // new public void Baslat() yazarakta hatayı ortadan kaldırabilirsin. derlersen yine otobüs kalkıyor yazısı gelir ama hatasız
        {               //new ile yeni metod üretmiş olursun ve diğerini gizlemiş olursun.. diğer yöntemide override-virtual..override yaptığını virtual yap.. 
            base.Baslat();  // base ana class olarak bilinen Araba class ının içersindeki verileri göstermesi bu sayede içindekileri görebiliriz...
            Console.WriteLine("Otobüs kalkıyor....");
        }
    }
}






//override c# tarafından yapmamızı öneren bir işlem
/* Araba class ının altında Baslat adında bir metod vardı.biz Araba clas ındaki Baslat() metodunun önüne bir virtual keyword ü ekledik. yani dedikki bu metod sanal bir metoddur. 
 * istenildiği taktirde bu metod diskalifiye edileblir ve bunun yerine yine başka bir metod değeri yazılabilir. Bu  şekilde metodlara override yöntemiyle üzerine yazma işlemi yapabilirsiniz
 * ..eğer virtual keywordünü silersek override adı altında bulunann keywordün sadece virtual, abstract ve override adı altında bulunan metodlar sayesinde kullanılabilceğini söylüyoruz.
 * override virtual yapmamızın nedeni ise çakışmay önlemek . iki class ın içindeki aynı isimli metodun da kullanılabileceğini söylüyoruz */