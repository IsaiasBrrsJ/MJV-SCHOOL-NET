using Microsoft.AspNetCore.Hosting.Server;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AulaSql.Dal
{
    public class ControleBaseDeDados 
    {
        private readonly string _connection;

        public ControleBaseDeDados()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();

           
            _connection = configuration.GetConnectionString("defaultConnection");
        }


        public void Conectar()
        {
         
            SqlConnection con = null;
          
            con = new SqlConnection(_connection);

            try
            {
                con.Open();
                SqlCommand comand = new SqlCommand();
                comand.CommandType = CommandType.Text;
                comand.CommandText = "SELECT * FROM dbo.pessoa";

                comand.Connection = con;
                var t = comand.ExecuteReader();
             
                while (t.Read())
                {
                    Console.WriteLine(t["Nome"]);
                }
               


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
