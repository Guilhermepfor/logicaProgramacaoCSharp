using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCSharp
{
    internal class ExemplosMath
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o maior valor que está entre dos dois números digitados (Y,X);
            Console.WriteLine(Math.Max(5, 10)); //10

            //Math.Min mostra o menos valor que está na faixa dos dois números digitados (Y,X);
            Console.WriteLine(Math.Min(5, 10)); //5

            //Math.sqrt mostra a raiz quadrada de um valor apresentado;
            Console.WriteLine(Math.Sqrt(2));    //2

            //Math.Abs retorna o valor absoluto de um número;
            Console.WriteLine(Math.Abs(-9));

            //Math.Round arredonda o valor;
            Console.WriteLine(Math.Round(9.99)); //10
        }
    }
}
