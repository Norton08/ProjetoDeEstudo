using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Maior_valor_de_Três
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 8-
            MaiorValor();        
        }
        static void MaiorValor()
        {
            Console.WriteLine("Escreva 3 valores que demonstrarei o maior dentre eles");

            Console.WriteLine("Primeiro valor:");
            float numb1= float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float numb2= float.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro valor");
            float numb3= float.Parse(Console.ReadLine());

            List<float> numbs= new List<float>();

            numbs.Add(numb1);
            numbs.Add(numb2);
            numbs.Add(numb3);

            float maiorvalor = numbs[0];
            Console.WriteLine("================");
            
            Console.WriteLine("O maior valor é " + maiorvalor);
        }
    }
}
