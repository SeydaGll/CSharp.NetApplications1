using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONet2BaglantiExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // şimdi database e bağlanacağızz....
            // ADIM1 : BAĞLANI İŞLEMİNİ GERÇEKLEŞTİR.. Veri TABANINa bağlanmamız için CONNECTion nesnesini kullanmamız gerekir. referanslar da default olarak System.Data var. bunu sadee using bloğuna eklicez
            //SqlConnection connection = new SqlConnection();
            //string cnnStr = "Data Source =.;AttachDbFileName = |DataDirectory|\\Database1.mdf; integrated security = True;User Instance = True;";
            //connection.ConnectionString = cnnStr;
            //connection.Open();

            //ADIM2: Bağlantı içerisine sorgu gönder
            //SqlCommand com = connection.CreateCommand();
            //com.CommandText = "Musteriler";
            //com.CommandType = System.Data.CommandType.TableDirect; //!

            
            

            //ADIM3 : giden cevaba göre gelen verilerin ne olduğunu tespit edelim..veri oku
             //SqlDataReader oku = new SqlDataReader();  böyle üretirsen hata cıkar
            SqlDataReader oku = com.ExecuteReader();  // sorguarım gönderilir

            //ADIM4: EKrana yazdır
            while (oku.Read())  // read() false true tarzında çalışır. okuma işlmei gerçekleştiği sürece döner
            {
                Console.WriteLine(oku[1] + " " + oku[2]);
            }

            //ADIM5: Bağlantıyı kapat
            connection.Close();

            Console.ReadLine();

            

        }
    }
}
