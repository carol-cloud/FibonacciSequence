using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0, second = 1, sum = 0;

            Console.Write("Quantidade de valores para imprimir a sequência Fibonacci: ");
            int values = int.Parse(Console.ReadLine());

            for (int i = 0; i < values; i++)
            {
                Console.Write(first + " ");
                sum = first + second;
                first = second;
                second = sum;
            }

            Console.ReadKey();

        }
    }
}
