using System.Text;

namespace Aula3
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = ( Forma.Nome = Forma.Nome + Forma.Nome "sd") 
            int resultado; ; // por valor => Stack
             string str = "ss"; //por referencia


            int valorA = 10;
            int valorB = valorA;

            string x = "aaaa"; //o que define um escopo de codigo é a {} =chave; o que tive fora disso não temos acesso;
            
            {
                int y = 10;
                Console.WriteLine(y);
            }

           

            AlterarVariavelPorValor(valorA);
            Console.WriteLine("Alterado por valor "+ valorA);

            AlterarVariavelPorReferencia(ref valorB);
            Console.WriteLine("Alterado por referencia " + valorB);

            Stream s = new MemoryStream();

            //byte[] bytes = Encoding.UTF8.GetBytes("isaias barros");


            // Array.ForEach(bytes, e =>
            //{

            //    File.AppendAllText(@"C:\bb.txt", e.ToString());
            //});

            var file = File.ReadAllLines(@"C:\bb.txt").ToList();

            file = file.Select(e =>
            {
                e = e.Replace("isaias", "teste");
                return e;

            }).ToList();

            File.WriteAllLines(@"C:\bb.txt", file);

            var ss = teste();

        
           
        }

        static void AlterarVariavelPorReferencia(ref int num )
        {
            num = 50;
        }

        static void AlterarVariavelPorValor(int ? num = 0)
        {
            num = 100;
        }

        public static (string t, int d) sss()
        {
           
            return ("isaias", 2);
        }

        public static Tuple<string, int> teste()
        {
            return new Tuple<string, int>("barros", 1);
        }
    }
}