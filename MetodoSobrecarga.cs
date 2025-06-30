using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class MetodoSobrecarga
    {

        static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static float Soma(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        static double Soma(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        static long Soma(long numero1, long numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha o tipo de número para somar:");
            Console.WriteLine("1 - Inteiros");
            Console.WriteLine("2 - Float");
            Console.WriteLine("3 - Double");
            Console.WriteLine("4 - Long");
            Console.Write("Opção: ");
            string escolha = Console.ReadLine();

            Console.Write("\nDigite o primeiro valor: ");
            string entrada1 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string entrada2 = Console.ReadLine();

            Console.WriteLine();

            switch (escolha)
            {
                case "1":
                    int int1 = int.Parse(entrada1);
                    int int2 = int.Parse(entrada2);
                    Console.WriteLine("Resultado (int): " + Soma(int1, int2));
                    break;

                case "2":
                    float float1 = float.Parse(entrada1);
                    float float2 = float.Parse(entrada2);
                    Console.WriteLine("Resultado (float): " + Soma(float1, float2));
                    break;

                case "3":
                    double double1 = double.Parse(entrada1);
                    double double2 = double.Parse(entrada2);
                    Console.WriteLine("Resultado (double): " + Soma(double1, double2));
                    break;

                case "4":
                    long long1 = long.Parse(entrada1);
                    long long2 = long.Parse(entrada2);
                    Console.WriteLine("Resultado (long): " + Soma(long1, long2));
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
