using System;
using System.Collections.Generic;

namespace _4.Três_nomes

{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 2-
            Console.WriteLine("Escreva 3 nomes");

            string nome1=Console.ReadLine();
            string nome2=Console.ReadLine();
            string nome3=Console.ReadLine();

            //Loop de repetição ficou inútil pois ele só executa uma única vez
            //e ele pega as variáveis que foram declaradas acima
            //Refazer o loop, sendo que o critério para ele continuar rodando é
            //enquanto o enquanto i for menor do que o count do array nomes
            //e precisa de apenas um único Console.WriteLine com a posição do array nomes que vc deseja
            //uma outra forma de resolver é usar um foreach ao invés do for

            string[] nomes= new string[3]{nome1, nome2 , nome3};

            Console.WriteLine("===========");

            foreach (string n1 in nomes)
            {
                Console.WriteLine(n1);
            }


        }
    }
}
