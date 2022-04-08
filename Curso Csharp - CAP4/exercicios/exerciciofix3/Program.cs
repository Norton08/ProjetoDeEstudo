using System;
using System.Globalization;

namespace exerciciofix3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno al;
            al = new Aluno();
            System.Console.Write("Nome do aluno: ");
            al.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite as três notas do aluno:");

            al.Nota1 = double.Parse(Console.ReadLine());

            al.Nota2 = double.Parse(Console.ReadLine());

            al.Nota3 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("====================================");

            System.Console.WriteLine("Nota final = " + al.Somatoria().ToString("F2", CultureInfo.InvariantCulture));

            if( al.Somatoria() > 60.0 ){

                System.Console.WriteLine("APROVADO");
            }
            else{
                System.Console.WriteLine("Reprovado");
                System.Console.WriteLine("Faltaram "+ al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }

        }
    }
}
