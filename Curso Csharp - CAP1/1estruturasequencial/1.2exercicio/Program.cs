using System;

namespace _1._2exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            float pi = 3.1416f;

            Console.WriteLine("Raio é");
            raio= float.Parse(Console.ReadLine());

            area = (pi * raio * raio);

            Console.WriteLine("A área é " + area);

        }
    }    
}
