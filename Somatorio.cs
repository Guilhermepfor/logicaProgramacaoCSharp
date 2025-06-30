using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Somatorio
    {
        public static void Main(string[] args)
        {
            int[] numero = new int[5];
            int somatorio = 0;

            Console.WriteLine("Somatório dos 5 valores digitados.");

            for (int i = 0; i < numero.Length; i++) {
                Console.WriteLine($"Digite um valor para somar: ");
                numero[i] = Convert.ToInt32(Console.ReadLine());
                somatorio += numero[i];
            }
            Console.WriteLine($"O somatório dos números é {somatorio}");
        }
    }
}
