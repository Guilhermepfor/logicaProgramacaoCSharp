using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Advinhacao
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(1, 101);
            int tentativa;
            int tentativasFeitas = 0;

            Console.WriteLine("Adivinhe o número de 1 a 100!");

            do
            {
                Console.Write("Digite seu palpite: ");
                tentativa = int.Parse(Console.ReadLine());
                tentativasFeitas++;

                if (tentativa < secreto)
                    Console.WriteLine("Tente um número maior.");
                else if (tentativa > secreto)
                    Console.WriteLine("Tente um número menor.");
                else
                    Console.WriteLine($"Parabéns! Você acertou em {tentativasFeitas} tentativas.");
            }
            while (tentativa != secreto);
        }
    }
}
