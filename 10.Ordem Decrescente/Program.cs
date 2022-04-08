using System;
using System.Linq;

namespace _10.Ordem_Decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 7-
            Console.WriteLine("Escreva o primeiro valor:");
            float decresnumb1= float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float decresnumb2= float.Parse(Console.ReadLine());
            
            Console.WriteLine("Terceiro valor:");
            float decresnumb3= float.Parse(Console.ReadLine());

            float [] numbs= new float[]{decresnumb1,decresnumb2,decresnumb3};

            Console.WriteLine("=============");

            Console.WriteLine("Aqui está");

            numbs=numbs.OrderByDescending(n=>n).ToArray();

            float i = numbs[0];
            foreach (int numerosdecrescentes in numbs)
            {
                Console.WriteLine(numerosdecrescentes + " ");
            }    
        }
    }
}
