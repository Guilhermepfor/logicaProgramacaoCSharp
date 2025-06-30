using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class FormasG
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha a forma geométrica para calcular:");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Círculo");
                Console.WriteLine("3 - Losango");
                Console.WriteLine("4 - Trapézio");
                Console.WriteLine("5 - Triângulo");
                Console.WriteLine("0 - Sair");

                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Quadrado();
                        break;
                    case "2":
                        Circulo();
                        break;
                    case "3":
                        Losango();
                        break;
                    case "4":
                        Trapezio();
                        break;
                    case "5":
                        Triangulo();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Quadrado()
        {
            Console.Write("\nInforme o lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * lado;
            double perimetro = 4 * lado;

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }

        static void Circulo()
        {
            Console.Write("\nInforme o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = Math.PI * raio * raio;
            double perimetro = 2 * Math.PI * raio;

            Console.WriteLine($"Área: {area:F2}");
            Console.WriteLine($"Perímetro (circunferência): {perimetro:F2}");
        }

        static void Losango()
        {
            Console.Write("\nInforme a diagonal maior: ");
            double dMaior = double.Parse(Console.ReadLine());

            Console.Write("Informe a diagonal menor: ");
            double dMenor = double.Parse(Console.ReadLine());

            double area = (dMaior * dMenor) / 2;

            Console.Write("Informe o lado do losango: ");
            double lado = double.Parse(Console.ReadLine());
            double perimetro = 4 * lado;

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }

        static void Trapezio()
        {
            Console.Write("\nInforme a base maior: ");
            double baseMaior = double.Parse(Console.ReadLine());

            Console.Write("Informe a base menor: ");
            double baseMenor = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Informe o lado esquerdo: ");
            double ladoEsq = double.Parse(Console.ReadLine());

            Console.Write("Informe o lado direito: ");
            double ladoDir = double.Parse(Console.ReadLine());

            double area = ((baseMaior + baseMenor) * altura) / 2;
            double perimetro = baseMaior + baseMenor + ladoEsq + ladoDir;

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }

        static void Triangulo()
        {
            Console.Write("\nInforme a base: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            double h = double.Parse(Console.ReadLine());

            double area = (b * h) / 2;

            Console.Write("Informe o lado 1: ");
            double l1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o lado 2: ");
            double l2 = double.Parse(Console.ReadLine());

            double perimetro = b + l1 + l2;

            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Perímetro: {perimetro}");
        }
    
    }
}
