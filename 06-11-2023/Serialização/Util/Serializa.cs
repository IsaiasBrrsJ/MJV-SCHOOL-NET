using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Util
{
    public static class Serializa
    {
        public static string Serializar(Carro.Carro carro)
            => JsonSerializer.Serialize(carro);

        public static Carro.Carro Deserialize(string carro) =>
             JsonSerializer.Deserialize<Carro.Carro>(carro)!;
        
    }
}
