using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaCSharp
{
    internal class Tabuada10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de 1 a 10\n");

            int[,] multiplicacao = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    multiplicacao[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tabuada do {i + 1}:");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i + 1} x {j + 1} = {multiplicacao[i, j]}");
                }
                Console.WriteLine(); // Linha em branco entre tabuadas
            }
        }
    }
}
