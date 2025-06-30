using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class Media
    {
        public static void Main(string[] args) {
            Console.WriteLine("Verifique se o aluno foi aprovado.");

            Console.WriteLine("Digite a primeira nota:");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            float n3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            float n4 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"\nMédia: {media:F2}");

            if (media > 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
