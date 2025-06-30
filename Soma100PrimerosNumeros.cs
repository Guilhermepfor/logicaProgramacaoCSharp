using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Soma100PrimerosNumeros
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos 100 primeiros números\n");

            int i = 1, totalSoma = 0;
            while (i < 101)
            {
                totalSoma += i;
                i++;
            }
            Console.WriteLine($"Total da soma dos 100 primeiros números\n{totalSoma}");
        }
    }
}