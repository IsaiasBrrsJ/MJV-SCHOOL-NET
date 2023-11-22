using ConsumoSQL;
using ConsumoSQL.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GerenciadorDeViagem.Data
{
    public class Banco : IBanco
    {

        private SqlConnection conection;
   
        public Banco()
        {
           
        }

        public SqlConnection AbrirConexao(string conexao)
        {
            conection = new SqlConnection(conexao);

            if (conection.State.Equals(ConnectionState.Closed))
            {
                try
                {
                    conection.Open();

                    return conection;
                }
                catch (SqlException)
                {

                    return null!;
                }
            }
            else
            {
                return conection;
            }
        }


        public void FecharConexao()
        {
            if (conection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    conection.Close();
                    conection.Dispose();
                }
                catch (SqlException)
                {
                    return;
                }
            }
        }


    }
}