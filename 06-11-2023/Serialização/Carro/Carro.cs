namespace Carro
{
    
    public class Carro
    {
        public Carro(int serie, string nome, string cor, int quantidadeDePortas)
        {
            Serie = serie;
            Nome = nome;
            Cor = cor;
            QuantidadeDePortas = quantidadeDePortas;
        }

        public int Serie { get; set; }

        public string Nome { get; set; }

        public string Cor { get; set; } 

        public int QuantidadeDePortas { get; set; }

        public override string ToString()
        {
            return $"Serie: {Serie}\nNome: {Nome}\nCor: {Cor}\nPortas: {QuantidadeDePortas}";
        }

    }
}