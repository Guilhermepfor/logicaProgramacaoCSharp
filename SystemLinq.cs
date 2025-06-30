using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class SystemLinq
    {
        public static void Main(string[] args)
        {
            int[] numeros = { 1, 5, 8, 15, 49 };
            Console.WriteLine(numeros.Min() + "\n"); //Menor valor
            Console.WriteLine(numeros.Max() + "\n"); //Maior valor
            Console.WriteLine(numeros.Sum() / numeros.Length + "\n"); //Media
        }
    }
}
