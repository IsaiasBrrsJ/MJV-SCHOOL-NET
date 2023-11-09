using Microsoft.AspNetCore.Mvc;
using partialView.Models;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace partialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  StreamWriter _writer;
        private Pessoa pessoa = new Pessoa();
        public HomeController(ILogger<HomeController> logger)
        {
      
          
            
            
            _logger = logger;
        }
 
        public IActionResult Index()
        {
            var poderes = new[] { "voar", "força", "sumir", "velocidade" };
          
            for (int i = 0; i < 10; i++)
            {
              
                pessoa.Nome = "Teste";
                pessoa.SobreNome = "teste2";
                pessoa.Poderes.Add(new Poderes
                {
                    nome = poderes[new Random().Next(0, poderes.Length-1)],
                    forca = new Random().Next(0, 10)
                });
            }
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult Index(string nome, string sobrenome)
        {
            var poderes = new[] { "voar", "força", "sumir", "velocidade" };

            for (int i = 0; i < 10; i++)
            {

                pessoa.Nome = "Teste";
                pessoa.SobreNome = "teste2";
                pessoa.Poderes.Add(new Poderes
                {
                    nome = poderes[new Random().Next(0, poderes.Length - 1)],
                    forca = new Random().Next(0, 10)
                });
            }
            _writer = new StreamWriter(@"C:\Users\Administrador\OneDrive - UFN - Universidade Franciscana\MJV DOTNET\08-11-2023\partialView\aulaAtual.txt", true);
            var jsonConverter = JsonSerializer.Serialize(new { Nome = nome, Sobrenome = sobrenome });

            _writer.WriteLine(jsonConverter);
            _writer.Close();
            _writer.Dispose();

            var auth = ViewBag.Autenticado;
            var nCompleto = ViewData["NomeCompleto"];
            var numero = TempData["Mensagem"];

            return View(pessoa);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}