using System;
using System.Collections.Generic;
using System.IO;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idIdentity = 0;
            const int valorBilhete = 5;
         
         

            do
            {
                Console.Clear();
                var seusNumeros = new List<string>();
                var JogadoresLoteria = new Dictionary<int, List<string>>();
                var numerosSortidos = new int[59];

                Console.WriteLine("5 reais para comprar um bilhete\n");

                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine()!;

                Console.WriteLine("Digite quanto deseja depositar: ");
                int valorDepositado;
                if (!int.TryParse(Console.ReadLine(), out valorDepositado))
                {
                    Console.WriteLine("Valor inválido.");
                    continue;
                }

                idIdentity++;

                Console.WriteLine($"Olá {nome} salve seu ID: {idIdentity}");

                var quantidadeDeBilhetes = valorDepositado / valorBilhete;

                Console.WriteLine($"Você depositou {valorDepositado.ToString("C")} e tem direito a {quantidadeDeBilhetes} bilhetes");

                for (int i = 0; i < numerosSortidos.Length; i++)
                {
                    numerosSortidos[i] = new Random().Next(1, numerosSortidos.Length + 2);
                }

                for (int i = 1; i <= quantidadeDeBilhetes; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                 
                        var random = numerosSortidos[new Random().Next(0, 59)];
                        seusNumeros.Add(random.ToString());
                    }
                }

                JogadoresLoteria.Add(idIdentity, seusNumeros);
                SalvaNoArquivo(JogadoresLoteria, valorAposta: valorDepositado);

            JogarNovamente:
                Console.Write("\nJogar novamente? 1 - Sim / 2 - Não / 3 - Exibir: ");
             

                if (!int.TryParse(Console.ReadLine(), out int jogarNovamente))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    goto JogarNovamente;
                }
                else if (jogarNovamente == 2)
                {
                    break;
                }
                else if (jogarNovamente == 3)
                {
                    Exibir(JogadoresLoteria);
                    goto JogarNovamente;
                }

               
            } while (true);
        }

        static void Exibir(Dictionary<int, List<string>> Jogadas)
        {
            Console.WriteLine("Digite o Id: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            if (Jogadas.ContainsKey(id))
            {
                List<string> lista = Jogadas[id];
                Console.WriteLine("Números escolhidos:");
                foreach (var numero in lista)
                {
                    Console.Write(numero + " | ");
                }
            }
            else
            {
                Console.WriteLine("A chave não foi encontrada no dicionário.");
            }

            Console.ReadKey();
        }

        static void SalvaNoArquivo(Dictionary<int, List<string>> conteudo, int valorAposta)
        {
            string path = @"C:\dados.txt";

            using (StreamWriter writer = new StreamWriter(path, append:true))
            {
                foreach (var valores in conteudo)
                {
                    writer.Write($"ID: {valores.Key};valor {valorAposta.ToString("C")};Números: ");
                    writer.WriteLine(string.Join(" | ", valores.Value));
                }
            }

            Console.WriteLine("Dados salvos no arquivo.");
        }
    }
}