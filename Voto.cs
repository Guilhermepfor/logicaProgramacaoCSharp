using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Voto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Consulte se você tem idade para votar.");

            int idade;

            Console.WriteLine("\nDigite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("\nVocê não tem idade para votar.");
            }
            else if (idade < 18)
            {
                Console.WriteLine("\nVocê pode votar, mas não é obrigatório.");
            }
            else
            {
                Console.WriteLine("\nÉ obrigatório votar.");
            }

        }
    }
}