using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class ForEachVetores
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Volkswagen", "Hyundai" };
            foreach (string marca in carro)
            {
                Console.WriteLine(marca);
            }
        }
    }
}
