namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Int16 i16 = 9999;
            Int32 i32 = 999999999;
            Int64 i64 = 999999999999999999;
            bool? ativo;
            int? ii;
            Int16? hh;
            string ss;

            var idade1 = 101;
            dynamic teste = idade1 + "2";
            Object iade4 = 10;// no .net tudo é Object

            var xx = Console.Read();
            var yy = Console.ReadKey();

            List<int> nn = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7,    8, 9, 10,   11, 12, 13, 14, 15, 16, 17, 18, 19

            };

            IQueryable<List<int>> l = from c in nn
                                      select c.roli;






            Console.WriteLine(DateTime.Now);
            Console.WriteLine(xx);
            Console.WriteLine(yy);

            Console.WriteLine("Tipo da variavel idade1: " + idade1.GetType());


            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine
           ($"Nome digitado: {nome} Idade: {idade}");
        }
        // C# coompila para IL ()
       
    }
  
}