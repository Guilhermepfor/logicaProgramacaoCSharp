using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Somando
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            int numero;

            do
            {
                Console.Write("Digite um número inteiro (0 para sair e somar todos os valores digitados): ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            while (numero != 0);

            Console.WriteLine($"\nSoma total: {soma}");
        }
    }
}
