using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -> Create Read Update Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("***********************************************");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adını Giriniz: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=SEVVAL-COMPUTER\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TBLCATEGORY (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Ekleme İşlemi Başarılı Bir Şekilde Eklendi!");

            #endregion


            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürünün Adını Giriniz: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Ürünün Fiyatını Giriniz: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection=new SqlConnection("Data Source=SEVVAL-COMPUTER\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TBLPRODUCT (ProductName,ProductPrice,ProductStatus) values (@productname,@productprice,@productstatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.Write("Ürün Eklemesi Başarılı Oldu!");


            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection=new SqlConnection("Data Source=SEVVAL-COMPUTER\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TBLPRODUCT", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürünün Id'sini Giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection=new SqlConnection("Data Source=SEVVAL-COMPUTER\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TBLPRODUCT Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı Bir Şekilde Gerçekleşti!");




            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Güncellenecek Ürünün Id'sini Giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürünün Adını Giriniz: ");
            string productName=Console.ReadLine();

            Console.Write("Güncellenecek Ürünün Fiyatını Giriniz: ");
            decimal productPrice=decimal.Parse(Console.ReadLine());

            SqlConnection connection= new SqlConnection("Data Source=SEVVAL-COMPUTER\\SQLEXPRESS01;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TBLPRODUCT Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Ürün Güncelleme İşlemi Başarılı Bir Şekilde Gerçekleşti!");

            #endregion

            Console.Read();

        }
    }
}
