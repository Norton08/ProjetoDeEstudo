using System;

namespace _6.Permissão_de_entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 4-
            Console.WriteLine("Escreva sua idade para continuar:");

            string valor=Console.ReadLine();

            int idade= Convert.ToInt32(valor);

            if (idade<18)
            {
                Console.WriteLine("Sem permissão de entrada");
            }
            else
            {
                Console.WriteLine("Permissão concedida");
            }
        }
    }
}
