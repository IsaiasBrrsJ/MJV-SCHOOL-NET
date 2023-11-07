using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Pessoa p = new Pessoa();
         
            p.Nome = "teste";
            p.Idade = 1;
            p.Apresentar();

           
        }
    }

    record teste(string nome, string senha);
    public class ContaBancaria
    {
        private double saldo;

        public void Depositar(double valor) { }

        public bool sacar(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }

        public double ObterSaldo()
        {
            return saldo;
        }
    }
    
    public interface IPagamento
    {
        void pix();
        void credito();
        void debito();
        void avista();
    }
}
