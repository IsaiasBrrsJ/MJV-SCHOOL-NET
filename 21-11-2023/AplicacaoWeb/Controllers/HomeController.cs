using AplicacaoAPI.Model;
using AplicacaoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace AplicacaoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAddBanco(Pessoa p)
        {
            HttpClient client = new HttpClient();
           string endpoint = "https://localhost:7212/api/CadastraPessoa/Pessoa";
           
            StringContent cont = new StringContent(JsonSerializer.Serialize(p), Encoding.UTF8, "application/json");

            var retorno = await client.PostAsync(endpoint, cont);

            var resposta =   retorno.Content.ReadAsStringAsync().Result;


            return RedirectToAction("Privacy", "Home", new { nome = resposta.ToString()});


        }

        public IActionResult Privacy(string nome)
        {
            return View(nome);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}