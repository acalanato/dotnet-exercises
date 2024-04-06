using System;

namespace IfDaVida
{
    class Program
    {    
        static void Main()
        {
            double portugues, legislacao, especifica, media;
            Console.WriteLine("Digite a nota de português: ");
            portugues = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota de legislação: ");
            legislacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da prova específica");
            especifica = double.Parse(Console.ReadLine());

            media = (portugues + legislacao + especifica) / 3;
            if (media >= 7)
            {
                Console.WriteLine($"Candidato aprovado: Média final = {media}");
            }
        }
    }
}
