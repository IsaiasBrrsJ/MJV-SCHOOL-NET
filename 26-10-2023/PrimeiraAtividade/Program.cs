using System.Globalization;
using System.Text.RegularExpressions;

namespace PrimeiraAtividade
{
    internal class Program
    {

     
        static void Main(string[] args)
        {


            
            /*
             meta de via 105 anos
            esposa 100
            
            -- construir  um projeto console application
            -- Digita nome
            -- data de nascimento
            -- 
            -- resultado
            até que dia eu estarei vivo sabendo que viverei por 100 anos
            
            ola .. voce vai viver ate ano tal mes tal dia tal
             */

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            
            DigitaDataDeNascimentoNovamente:
            Console.WriteLine("Digite sua data de nascimento: ");
            string dataNascimento = Console.ReadLine();

            var validaDataNascimento = VerificaSeDataEstaNoFormatoCorreto(dataNascimento);

            if (validaDataNascimento.sucesso is false) { goto DigitaDataDeNascimentoNovamente; }

            var idade = CalculaIdade(validaDataNascimento.ano, validaDataNascimento.mes, validaDataNascimento.dia);

            var resultado = CalculoTempoDeVida(idade);

            Console.WriteLine($"Olá {nome} voce tem {idade} Ano(s) e ainda pode viver por {resultado.tempoRestante} Ano(s) "+
                $"Dia final: [{resultado.diaEstimado}/{resultado.mesEstimado}/{resultado.anoEstimado}]");

        }
        static (int dia, int mes, int ano, bool sucesso) VerificaSeDataEstaNoFormatoCorreto(string dataNascimento)
        {
            Regex regex = new Regex(@"(\d+)\/(\d+)(?=\/\d{4})\/(\d{4})$");
            var convertidoComSucesso = DateTime.TryParse(dataNascimento, CultureInfo.GetCultureInfo("pt-BR"), out DateTime dataNasc);

            if (!regex.Match(dataNascimento).Success || convertidoComSucesso is false)
            {
                return (0, 0,0, false);
            }
         


            var dia = Convert.ToInt16(regex.Match(dataNascimento).Groups[1].Value);
            var mes = Convert.ToInt16(regex.Match(dataNascimento).Groups[2].Value);
            var ano = Convert.ToInt16(regex.Match(dataNascimento).Groups[3].Value);

            return (dia, mes, ano, true);
        }
        static int CalculaIdade(int ano =0, int mes =0, int dia = 0)
        {
            DateTime dataDeNascimento = new DateTime(ano, mes, dia);

            int calculoIdade = Convert.ToInt16((DateTime.Now - dataDeNascimento).TotalDays);

            return calculoIdade / 365;   
        }

        static (int anoEstimado,int mesEstimado, int diaEstimado, int tempoRestante) CalculoTempoDeVida(int idade)
        {
            const int tempoMaximoDeVida = 100;

            int tempoRestante = tempoMaximoDeVida - idade;
            DateTime calculoAnosRestantes = DateTime.Now.AddYears(tempoRestante);

            int anoEstimado = calculoAnosRestantes.Year;
            int mesEstimado = calculoAnosRestantes.Month;
            int dia = calculoAnosRestantes.Day;

            return  (anoEstimado, mesEstimado, dia, tempoRestante);

        }
    }
}