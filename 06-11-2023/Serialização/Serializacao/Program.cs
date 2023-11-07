namespace Serializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro.Carro carro = new Carro.Carro(2, "IdBuzz", "Azul", 4);
            Util.Operacao.GravaArquivo(carro);

            Util.Operacao.LerArquivo();
        }
    }
}