using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class TabuadaArray
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            int[] resultados = new int[10];

            for (int i = 0; i < 10; i++)
            {
                resultados[i] = numero * (i + 1);
            }

            Console.WriteLine($"\nTabuada do {numero}:\n");

            //Resultados
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{numero} x {i + 1} = {resultados[i]}");
            }
        }
    }
}
