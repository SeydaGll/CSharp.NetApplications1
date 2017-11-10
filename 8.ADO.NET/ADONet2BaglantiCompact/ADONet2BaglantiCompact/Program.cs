using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONet2BaglantiCompact
{
    class Program
    {
        static void Main(string[] args)
        {
            // local database yani compact edition kullanıldı...(sql server compact edition dan gelir)
            /* Compact için
              
              ADIM 1 : VERİ TABANINA BAĞLANTI SAĞLA VE BAĞLANTIYI AÇ
              SqlCeConnection myCnn = new SqlCeConnection("Data Source = Database.sdf")
              myCnn.Open(); 
             
              ADIM2: DAtabase e sorgu gönder
              Sorguları içeren bir class ımız daha var.. veri tabanına sorgu gönderen class dır..
              SqlCeCommand myCom = new SqlCeCommand();  örnek üret ve sorguyu üret
              myCom = myCnn.CreateCommand();
              myCom.CommandTxt = "Musteriler";   müşteriler tablosuna bağlan . bu bağlantıyı yapması için bağlantı adresini tanıması gerekir
              myCom.CommandType=System.Data.CommandType.TableDirect ;    enum deperler

              ADIM 3: VERİ OKU VE BU VERİLERİN DEĞERİNİ YAZIDR
              SqlCeDataReader myDataReader = myCom.ExecuteReader();  // artık verilerim myDataReader ın içerisinde

                while(myDataReader.Read())
                {
                    Console.WriteLine(myDataReader[1] + " " + myDataReader[2]) ;  1. ve 2. SÜTUN ları okumuş olucam            
    
                }

             ADIM4: veriler alındı ekrana yazdırıldı artık bağlantı kapatılır
             myCnn.Close();  

    connection sonlanmıştır.yani içerisine girip yeni sorgular ekleyemeyiz yada yeni veriler okuyamayız.. veri okunmak için açılması gerekir
    */

        }
    }
}
