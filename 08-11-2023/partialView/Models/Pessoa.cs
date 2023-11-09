namespace partialView.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } = string.Empty!;

        public string SobreNome { get; set;} = string.Empty!;

        public List<Poderes> Poderes { get; set; } = new List<Poderes>(); 
    }
}
