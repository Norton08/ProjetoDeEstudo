using System;

namespace _8.Minha_altura_é
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua altura?");

            Double h= Convert.ToDouble(Console.ReadLine());

            Height(h);
        }
        static void Height(double h)
        {      
            Console.WriteLine("=================");

            Console.Write("Sua altura é "+ h);
        }
    }
}
