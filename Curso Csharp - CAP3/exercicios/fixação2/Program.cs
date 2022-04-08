using System;
using System.Globalization;

namespace fixação2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            string sobrenome = vet[1];

            System.Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com o preço do produto");
            double preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            System.Console.WriteLine(nome + " " + sobrenome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(sobrenome);
            System.Console.WriteLine(idade);
            System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
