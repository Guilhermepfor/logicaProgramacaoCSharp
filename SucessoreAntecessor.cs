using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class SucessoreAntecessor
    {
        public static void Main(string[] args)
        {
            Console.Write("Verifique qual o sucessor e antecessor do valor digitado.\n");
            Console.Write("\nDigite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine($"\nAntecessor: {antecessor}");
            Console.WriteLine($"Sucessor: {sucessor}");
        }
    }
}
