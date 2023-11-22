using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsumoSQL.Models
{
    public interface IBanco
    {
        public SqlConnection AbrirConexao(string conexao);
      


        public void FecharConexao();

    }
}
