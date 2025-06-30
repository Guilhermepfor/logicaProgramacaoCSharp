using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class MetodosComParametros
    {
        public static void Main(string[] args)
        {
            Nome("Ingrid ");
            Nome("Fabiana ");
        }
        public static void Nome(string nome)
        {
            Console.WriteLine(nome + "Bassi");
        }
    }
}
