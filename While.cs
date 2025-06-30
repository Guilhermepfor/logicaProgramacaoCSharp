using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class While
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("While Loop\n\n");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("A vida do Jaja ta muito fácil.");
                i++;
            }
        }
    }
}
