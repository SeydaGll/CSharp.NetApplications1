using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet2DisconnectionExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Uygulama Tamam
            // 1.Uygulama..veri değerinin tutulması. veritabanının disconnect yapılması sonrasında yaptık
            //SqlConnection myConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\\database1.mdf; Integrated Security = True");
            //myConnection.Open();

            //SqlCommand myCommand = myConnection.CreateCommand();
            //myCommand.CommandText = "Select * from Musteriler";
            //myCommand.CommandType = System.Data.CommandType.Text;

            //SqlDataAdapter myDataAdapter = new SqlDataAdapter(myCommand);

            //DataSet myDataSet = new DataSet();  // içerisinde satır ve sütunların bulunduğu bir veritabanı görünümündedir...

            //myDataAdapter.Fill(myDataSet);
            //myConnection.Close();  // Bunlar artık ram in üzerinde bulunmaktadır.. çünkü ben bunları Dataset içerisine aldım. şimdi bunları foreach ile alalım



            //foreach (DataRow myRow in myDataSet.Tables[0].Rows)  // DataRow ile satırları arıcak.Datarow tipinde buradaki veritabanı içerisindeki DataSeti gez
            //{                                               // myDataseti in içerisine gir.bunun içerisinde tables adı altında property var.tables koleksiyonu var.bunun satırları içerisindeki değerleri ara
            //    Console.WriteLine(myRow[0] + " " + myRow["Adi"] + " " + myRow["Soyadi"]);
            //}
            #endregion
            // dosyanızın bulunduğu konum projenizin bulunduğu konumla aynı olmak zorundadır
            string cnnStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\database1.mdf; Integrated Security = True";
            SqlConnection myConnection = new SqlConnection(cnnStr);
            myConnection.Open();

            SqlDataAdapter myAdapter = new SqlDataAdapter(); // adaptor tanımalama işlemi

            //Select sorgusu oluştur
            myAdapter.SelectCommand = myConnection.CreateCommand();  // sorgu oluşturuldu
            myAdapter.SelectCommand.CommandText = "Select * from Musteriler"; // seçme tamamlandı

            //ekleme işlemi insert into

            myAdapter.InsertCommand = myConnection.CreateCommand();
            myAdapter.InsertCommand.CommandText = "Insert Into Musteriler (Adi,Soyadi,Sehir) values (@Adi,@Soyadi,@Sehir)";
            myAdapter.InsertCommand.Parameters.Add("@Adi", SqlDbType.NVarChar, 50, "Adi");
            myAdapter.InsertCommand.Parameters.Add("@Soyadi", SqlDbType.NVarChar, 50, "Soyadi");
            myAdapter.InsertCommand.Parameters.Add("@Sehir", SqlDbType.NVarChar, 50, "Sehir");

            //Güncelleme işlemleri uPTADE
            myAdapter.UpdateCommand = myConnection.CreateCommand();
            myAdapter.UpdateCommand.CommandText = "update Musteriler set Adi = @Adi, Soyadi= @Soyadi, Sehir=@Sehir where MusteriID = @MusteriID";
            myAdapter.UpdateCommand.Parameters.Add("@MusteriID", SqlDbType.Int, 4, "MusteriID");
            myAdapter.UpdateCommand.Parameters.Add("@Adi", SqlDbType.NVarChar, 50, "Adi");
            myAdapter.UpdateCommand.Parameters.Add("@Soyadi", SqlDbType.NVarChar, 50, "Soyadi");
            myAdapter.UpdateCommand.Parameters.Add("@Sehir", SqlDbType.NVarChar, 50, "Sehir");

            //sİLME işlemleri DELETE
            myAdapter.DeleteCommand = myConnection.CreateCommand();
            myAdapter.DeleteCommand.CommandText = "Delete from Musteriler where MusteriID =@MusteriID";
            myAdapter.DeleteCommand.Parameters.Add("@MusteriID", SqlDbType.Int, 4, "MusteriID");


            // verileri depolama
            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet);

            // bağlantı kapat
            myConnection.Close();

            Console.WriteLine("Veri Tabanındaki Tabloların içerisindeki Veriler ==> Önce");
            foreach (DataRow item in myDataSet.Tables[0].Rows)
            {
                Console.WriteLine(item[0] + " "+ item["Adi"] + " "+item["Soyadi"]); 

            }
            Console.WriteLine("Eski verileri alma işlemi tamamlandı");
            Console.WriteLine();

            // veri ekleme
            Console.WriteLine("Veri ekleme başladı");
            DataRow myRow = myDataSet.Tables[0].NewRow();
            myRow["Adi"] = "Ahmet";
            myRow["Soyadi"] = "Bircan";
            myRow[3] = "KONYA";
            myDataSet.Tables[0].Rows.Add(myRow);

            Console.WriteLine("eKLEME işlemi tamamlandı");

            // silme işlemi
            Console.WriteLine("Silme İşlemi başladı");
            myDataSet.Tables[0].Rows[1].Delete();
            Console.WriteLine("Silme işlmei tamamlandı");

            //güncelleme işlemi
            Console.WriteLine("güncelleme işlmei başlıyor");
            myDataSet.Tables[0].Rows[0]["Adi"] = "Ramazan";

            // En son işlme tabloya kaydet ve tabloyu güncelle
            myAdapter.Update(myDataSet);

            Console.WriteLine("işlem tamamladı. tablonun son hali...");

            foreach (DataRow item in myDataSet.Tables[0].Rows)
            {
                Console.WriteLine(item[0]+ " " + item[1] + " "+ item[2] + " "+ item["Sehir"]);
            }

            Console.ReadLine();














            Console.ReadLine();


        }
    }
}
