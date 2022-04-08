using System;

namespace _7.Apresentação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 5-
            Apresentação();
        }
        static void Apresentação()
        {
            Console.WriteLine("Apresentação!:");

            string nome=Console.ReadLine();

            Console.WriteLine("==========");

            Console.Write("Olá meu nome é "+ nome);

        }
    }
}
