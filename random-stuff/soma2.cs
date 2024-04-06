using System;
namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist;
            decimal valor;

            dist = 10;
            valor = 4 * dist + 4.5M;

            Console.WriteLine($"Valor {valor}");
        }
    }
}
