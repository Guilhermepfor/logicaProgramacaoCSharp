using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{

    internal class Operacoes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" -- Operações Matemáticas -- ");
            Console.WriteLine("Escolha o tipo de operação matemática:\n");
            Console.WriteLine("[+] Soma");
            Console.WriteLine("[-] Subtração");
            Console.WriteLine("[*] Multiplicação");
            Console.WriteLine("[/] Divisão");

            Console.Write("Digite o símbolo da operação desejada: ");
            string operacao = Console.ReadLine();

            Console.Write("Digite o primeiro valor: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            double resultado = Calcular(num1, num2, operacao);

            Console.WriteLine($"\nResultado da operação: {resultado}");
        }

        public static double Calcular(int a, int b, string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    if (b != 0)
                        return (double)a / b;
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return 0;
                    }
                default:
                    Console.WriteLine("Operação inválida.");
                    return 0;
            }
        }
    }
}
