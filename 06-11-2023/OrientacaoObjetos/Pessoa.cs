using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Pessoa
    {
        public string Nome { get; set; } = default!;

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} Ano(s)");
        }
    }

    public class Funcionario : Pessoa
    {
        public double Salario { get; set;}
    }

    public class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("Latido");
        }
    }

    public class Cachorro : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("Miando");
        }
    }

}
