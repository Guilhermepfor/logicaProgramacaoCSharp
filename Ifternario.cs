using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Ifternario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo Ifternário");
            Console.WriteLine("Quanto é 2 + 2?");
            Console.WriteLine("\nSua resposta: ");
            int resposta = Convert.ToInt32(Console.ReadLine());
            string verificar = (resposta < 4) ? "Errou?!" : "Acertou! Fácil né?";
            Console.WriteLine(verificar);
        }
    }
}
