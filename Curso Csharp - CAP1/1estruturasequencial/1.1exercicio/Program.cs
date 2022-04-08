using System;

namespace _1estruturasequencial
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int codigo1, codigo2, quantidade1, quantidade2;
            double valorUnitario1, valorUnitario2, valorTotal;

            Console.WriteLine("Código 1: ");
            codigo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade 1: ");
            quantidade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário 1: ");
            valorUnitario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Código 2: ");
            codigo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade 2: ");
            quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor unitário 2: ");
            valorUnitario2 = double.Parse(Console.ReadLine());

            valorTotal = (valorUnitario1 * quantidade1) + (valorUnitario2 * quantidade2);

            Console.WriteLine("Valor a pagar: {0:f2}", valorTotal);
            Console.ReadKey();
        }

    }
}
