namespace exerciciosString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* contains
               equals
               IndefOf
               PadLeft
               PadRigth
               Replace
               Split
               ToLower
               ToUpper
               Substring
               
             */
            DateTime Date = DateTime.Now;

            Console.WriteLine(Date.ToString("dddd, dd 'de' MMMM 'de' yyyy"));

         

            var trim = new[] { '.', '-', ',' };
            Console.Write("Digite seu nome: ");
             string nome = Console.ReadLine()!;


            if(!String.IsNullOrWhiteSpace(nome))
            {
               string nomeTrim      = nome.Trim(trim);
               string nomePadLeft   = nome.PadLeft(nome.Length * 2, '-');
               string nomePadRight  = nome.PadRight(nome.Length + 5, '0');
               string nomeSubstring = nome.Substring(0, nome.Length - 3);
               string nomeReplace   = nome.Replace("barros", "barros teste");
               string[] nomeSplit   = nome.Split(' ');
               var nomeCompareTo    = nome.CompareTo(nomeTrim);
               string nomeInsert    = nome.Insert(nome.Length, " - testeFinal");
               string nomeToUpper   =  nome.ToUpper();
               string nomeToLower   = nome.ToLower();
              

                Console.WriteLine(nomeInsert);
            }
            try
            {
                Console.WriteLine("Digite um numero: ");
                int nume = int.Parse(Console.ReadLine()!);
            }
            catch(System.DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(System.Exception e) 
            {
                Console.WriteLine(e.Message);
                throw;
            }
           

        }

    
    }
}