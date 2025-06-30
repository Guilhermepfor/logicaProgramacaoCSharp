using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Cor
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Texto em ciano.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto amarelo");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Texto branco com fundo azul!");

            Console.ResetColor();
            Console.WriteLine("Cores resetadas.");
        }
    }
}
