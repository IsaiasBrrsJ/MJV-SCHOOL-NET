using ConsumoSQL.Models;
using GerenciadorDeViagem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ConsumoSQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  IOptions<Config> _connectionString;
        private readonly IBanco _banco;
        public HomeController(ILogger<HomeController> logger, IOptions<Config> connectionString, IBanco banco)
        {
            _logger = logger;
            _connectionString = connectionString;
            _banco = banco;
        }

        public IActionResult Index()
        {
           var banco = _banco.AbrirConexao(_connectionString.Value.connectionString);

            SqlCommand commando = new SqlCommand();
            commando.Connection = banco;

            commando.CommandType = System.Data.CommandType.Text;
            commando.CommandText = "SELECT * FROM Usuarios";

            var reader = commando.ExecuteReader();
            var nome = "";
            var email = "";
            List<string> pessoa = new List<string>();
            
            while (reader.Read())
            {
                nome = reader["emai"].ToString();
                email = reader["email"].ToString();
                pessoa.Add(nome + " " + email);
            }

            _banco.FecharConexao();

            return View(pessoa);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}