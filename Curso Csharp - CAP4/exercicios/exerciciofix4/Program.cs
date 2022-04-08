using System;
using System.Globalization;
namespace exerciciofix4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = ConversorDeMoeda.ValorASerPago(quantia , cotacao);

            System.Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorASerPago(quantia , cotacao).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
