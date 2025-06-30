using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class VetorMatriz
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "Ford", "BMW", "Mazda" };
            int[] numero = { 10, 20, 30, 40 };

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(carro[i]);
                Console.WriteLine(numero[i]);
            }
        }
    }
}
