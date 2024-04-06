using System;

namespace Login
{
    class Program
    {
//        public static string senha = "teste";
        public static void Main(string[] args)
        {
            for(int i = 0;i < 3; i++)
            {
                string senha = "teste";
                Console.WriteLine("Adivinhe a palavra:");
                if(Console.ReadLine().Equals(senha))
                {
                    Console.WriteLine("Senha Correta");
                    break;
                }
            }
        }
    }
}
