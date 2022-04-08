using System;
using System.Text;

namespace _3.Nomerepetido
{
    class Program
    {
        public static object Enumarable { get; private set; }

        static void Main(string[] args)
        {
            //Exercício 1-
            Console.WriteLine("Escreva um nome");

            string nome = Console.ReadLine();

            Console.WriteLine("==============");
            
            Console.WriteLine(nome);
        }
    }
}
