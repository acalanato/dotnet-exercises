using System;
namespace Calcula
{
    class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Console.WriteLine("Somar:" + calc.Somar(2, 2));
            Console.WriteLine("Subtrair: " + calc.Subtrair(4, 2));
        }
    }
}
