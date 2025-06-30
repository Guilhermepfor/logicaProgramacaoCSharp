using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class InverterArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Invertendo a ordem dos valores digitados");
            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros na ordem inversa:");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
