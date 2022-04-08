using System;
using System.Globalization;

namespace exerciciofix2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            System.Console.Write("Sálario Bruto: ");
            f.SalarioBruto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine();

            System.Console.WriteLine("Funcionário: " + f);

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcent);

            System.Console.WriteLine();

            System.Console.WriteLine("Dados atualizados = " + f);

        }
    }
}
