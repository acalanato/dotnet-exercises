﻿// See https://aka.ms/new-console-template for more information
using System;

class Ex
{
    static void A()
    {
        for (int i = 1; i <= 10; i++){
            Console.WriteLine(i * 4);
        }
    }
    static void B()
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            do {
            Console.WriteLine("\nEscolha o exercício para exibir ou CTRL+C para sair:");
            Console.WriteLine("[a] [b] [c] [d] [e]");
            string opt = Console.ReadLine().ToLower();
            switch (opt)
                {
                case "a":
                    Console.Clear();
                    Console.WriteLine("a) Apresentar todos os valores numéricos inteiros ímpares\nsituados na faixa de 0 a 40.");
                    A();
                    break;
                case "b":
                    Console.Clear();
                    Console.WriteLine("b) Apresentar o total da soma dos 100 primeiros números\ninteiros, representados pela sequência 1+2+3+4...+98+99+100.");
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine("c) Apresentar todos os números divisíveis por 4 que sejam\nmenores que 40. Iniciar a contagem com o valor 1 (um).");
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine("d) Apresentar os quadrados dos números inteiros de 15 a 200.");
                    break;
                case "e":
                    Console.Clear();
                    Console.WriteLine("e) Apresentar o resultado da soma de todos os valores pares\nexistentes na faixa numérica de 1 a 50.");
                    break;
                }
            } while(true);
        }
    }
}
}
Test
