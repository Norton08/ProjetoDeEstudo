using System;
using System.Globalization;

namespace exerciciofix1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();
            System.Console.WriteLine("Entre com a largura e a altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
            
        }
    }
}

