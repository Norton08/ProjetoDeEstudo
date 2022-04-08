using System;
using System.Collections.Generic;

namespace _12.Primeiro_Maior_que_a_Soma_dos_outros_Dois_de_Três
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaNumeros = PecaParaOUsuarioInformarTresNumeros();
            
            if (listaNumeros[0] > listaNumeros[1] +listaNumeros[2])
            {
                Console.WriteLine("Valor verificado corretamente");
            }    
            else
            {
                Console.WriteLine("Valor não válido com a prerrogativa");
            }
        }
        static List<double> PecaParaOUsuarioInformarTresNumeros()
        {
            Console.WriteLine("Escreva tres numeros que eu vou verificar se o primeiro é maior que a soma dos outros dois:");
            
            var listaNumeros = new List<double>();

            Console.WriteLine("Primeiro valor:");
            var numb1= double.Parse(Console.ReadLine());
            listaNumeros.Add(numb1);

            Console.WriteLine("Segundo valor:");
            double numb2= double.Parse(Console.ReadLine());
            listaNumeros.Add(numb2);

            Console.WriteLine("Terceiro valor:");
            double numb3= double.Parse(Console.ReadLine());
            listaNumeros.Add(numb3);

            return listaNumeros;
        }
    }
}
