using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class ParOuImpar
    {
        public static void Main(string[] args){
            Console.WriteLine("Verifique se o número é par ou ímpar.");

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine("O número é par.");
            }
            else {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
