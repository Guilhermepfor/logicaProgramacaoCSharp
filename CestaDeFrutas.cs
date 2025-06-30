using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class CestaDeFrutas
    {
        public static void Main(string[] args)
        {
            Fruta frutas = new Fruta();
            Console.WriteLine($"Fruta: {frutas.nome} - Preço: R$:{frutas.preco}");
        }
    }
}
