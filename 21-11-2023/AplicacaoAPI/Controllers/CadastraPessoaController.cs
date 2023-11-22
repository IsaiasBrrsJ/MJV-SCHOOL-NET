using AplicacaoAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;

namespace AplicacaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastraPessoaController : ControllerBase
    {
        private readonly IOptions<ConnectionString> _connectionString;
        public CadastraPessoaController(IOptions<ConnectionString> connectionString)
        {

            _connectionString = connectionString;

        }
        [HttpPost("Pessoa")]
        public async Task<IActionResult> CadastraPessoa(Pessoa pessoa)
        {
            if (pessoa is null)
                return BadRequest();

        

            SqlConnection sql = new SqlConnection(_connectionString.Value.SqlConnectionString);
            SqlCommand sqlCommand =new SqlCommand();    
            try
            {
                sql.Open();
                sqlCommand.Connection = sql;
                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.CommandText = @"Insert into Pessoa (nome) values(@Nome)";

                sqlCommand.Parameters.AddWithValue("@Nome", pessoa.Nome);

                await sqlCommand.ExecuteNonQueryAsync();
               
                return Ok(pessoa);
            }
            catch {
                return BadRequest();
            }
            finally
            {
                sql.Close();
                sqlCommand.Dispose();
            }
        }
    }
}
