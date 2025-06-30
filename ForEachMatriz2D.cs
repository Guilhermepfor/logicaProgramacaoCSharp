using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class ForEachMatriz2D
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3 }, { 5, 7, 8 } };

            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}
