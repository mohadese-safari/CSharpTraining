using Store.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AddNewCustomer();
            //string code = "1z2b3c";
            //string name = "bracelets";
            //using(SqlConnection connection = CreateConnection())
            //{
            //    connection.Open();
            //    var cmd = new SqlCommand();
            //    cmd.Connection = connection;
            //    cmd.CommandText = String.Format("INSERT INTO Product(Code,Name) VALUES (@code,@name)", code, name); ;
            //    cmd.Parameters.AddWithValue("@code", code);
            //    cmd.Parameters.AddWithValue("@name", name);
            //    cmd.ExecuteNonQuery();
            //}

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }

        public static String GetConnectionString()
        {
            var a = ConfigurationManager.ConnectionStrings["Store"];
            return ConfigurationManager.ConnectionStrings["Store"].ConnectionString;
        }

        public static void AddNewCustomer()
        {
            Customer c = new Customer
            {
                Title = "Mozhgan",
                PhoneNumber = "0912"
            };
            using (var db = new StoreDbContext())
            {
                db.Customers.Add(c);
                db.SaveChanges();
            }
        }
    }
}
