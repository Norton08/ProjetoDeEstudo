using System;

namespace _9.Bimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6-
            Media();
        }
        static void Media()
        {
            Console.WriteLine("Bimestre 1:");
            float notabim1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Bimestre 2:");

            float notabim2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Bimestre 3:");

            float notabim3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Bimestre 4:");

            float notabim4 = float.Parse(Console.ReadLine());

            float media = notabim1/4 + notabim2/4 + notabim3/4 + notabim4/4;
            if (media >= 6)
            {
                Console.WriteLine("Aluno Aprovado com média " + media);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado com média " + media);
            }
        }
    }
}
