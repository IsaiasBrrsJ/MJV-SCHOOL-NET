namespace Atividade2
{
    internal class Program
    {   
        //"Tenho 20 reais " quntas vezes vou jogar
        static void Main(string[] args)
        {
            const int valorBilhete = 5;
            Console.WriteLine("5 reais para comprar um bilhete\n");
            
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Digite quanto deseja depositar: ");
             int valorDepositado = int.Parse(Console.ReadLine()!);


            var quantidadeDeBilhetes = valorDepositado / valorBilhete;

            Console.WriteLine($"Voce depositou {valorDepositado.ToString("C")} tem direito a {quantidadeDeBilhetes} bilhetes");

            var numerosSortidos = new int[59];
            var seusNumeros = new int[6];

            for(int i = 0; i < numerosSortidos.Length; i++)
            {
                numerosSortidos[i] = new Random().Next(1, numerosSortidos.Length + 2);
            }

            for(int i = 1; i <= quantidadeDeBilhetes; i++)
            {
                Console.WriteLine($"{i}º Jogada: ");

                for (int j = 0; j < seusNumeros.Length; j++)
                {
                    gerarNovamente:
                    var ramdom = numerosSortidos[new Random().Next(0, 59)];

                    if (seusNumeros.Contains(ramdom))
                       goto gerarNovamente;

                    seusNumeros[j] = ramdom;

                    Console.Write(seusNumeros[j]+" |");
                }
                Console.WriteLine("\n-------------");
            }
        }
    }
}