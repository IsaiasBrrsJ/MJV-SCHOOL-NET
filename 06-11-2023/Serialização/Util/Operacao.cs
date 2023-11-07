namespace Util
{
    public static class Operacao
    {
        private static string diretorio = @"C:\Serializados";
        private static string nomeArquivo = "serializados.txt";
        public static void GravaArquivo(Carro.Carro carro)
        {
            string arquivo = CriaDiretorioArquivo();

            string serializado = Serializa.Serializar(carro);
            File.AppendAllText(arquivo, serializado+Environment.NewLine);
           
        }
        public static void LerArquivo()
        {
            List<Carro.Carro> carros = new List<Carro.Carro>();

            StreamReader reader = new StreamReader(Path.Combine(diretorio, nomeArquivo));

            while (!reader.EndOfStream)
            {   
                string carro = reader.ReadLine()!;   
                var deserealize = Serializa.Deserialize(carro);
                carros.Add(deserealize);
            }
            reader.Close();

            carros.ForEach(Console.WriteLine);
        }
        private static string CriaDiretorioArquivo()
        {

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            if(!File.Exists(nomeArquivo)){
                File.Create(nomeArquivo).Close();
            }

            return Path.Combine(diretorio, nomeArquivo);
        }
    }
}