using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlarinaGiris
{
    class Program
    {
        static void Main(string[] args)

        {
            string metin = "Ya Olduğun Gibi Görün Yada Göründüğün Gibi Ol. 'Hz.Mevlana'   ".Trim;

            //Sunstring
            //metin = metin.Substring(3); // ilk 3 karakteri atladı diğerlerini yazdırdı --Olduğun Gibi Görün Yada Göründüğün Gibi Ol. 'Hz.Mevlana'
            //metin = metin.Substring(3, 12);  // -- Olduğun Gibi.. sustringleri almak için kullanabilrsin.  remove metodu ile haricinde olanları görmek için kullanabilirsin

            //ToUpper
            //metin = metin.ToUpper();    --YA OLDUĞUN GİBİ GÖRÜN YADA GÖRÜNDÜĞÜN GİBİ OL. 'HZ.MEVLANA'

            //ToLower
            //metin = metin.ToLower();  ---ya olduğun gibi görün yada göründüğün gibi ol. 'hz.mevlana'

            //Replace
            //metin = metin.Replace('ğ', 'g');  --Ya Oldugun Gibi Görün Yada Göründügün Gibi Ol. 'Hz.Mevlana'. bu metodu genellikle türkçe karakteri silmek ve ingilizceye cevirmek içib kullanılır
            //metin = metin.ToLower().Replace('i', 'ı').ToUpper();   --YA OLDUĞUN GIBI GÖRÜN YADA GÖRÜNDÜĞÜN GIBI OL. 'HZ.MEVLANA'
            //metin = metin.Replace("Ya", "YA");    --YA Olduğun Gibi Görün YAda Göründüğün Gibi Ol. 'Hz.Mevlana'
            //metin = metin.Replace(" ", "_________");

            //Trim -- EN BAŞTAKİ VE en sondaki boşukları silen metod
            //metin = metin.Trim();  -- sağ ve soldaki boşluklar siliniyor

            //TrimEnd
            //metin = metin.TrimEnd(); -- en sonda bulunan boşluk değerlerini silecektir.

            //TrimStart
            //metin = metin.TrimStart();

            //Length -- içindeki karakter sayısını gösterir
            //int karakterSayisi = metin.Length;
            //Console.WriteLine(karakterSayisi);

            Console.WriteLine("İLKER IŞIK".Substring(6).Length);  // BU Şekilde de yapılabilir...


            //Console.WriteLine(metin);
            Console.ReadLine();


        }
    }
}
