using System;

namespace Par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Executando a função ParImpar
            ParImpar();

            static void ParImpar()
            {
                int a=0;
                int b=0;
                Console.WriteLine("Escreva um numero:");

                a= Convert.ToInt32(Console.ReadLine());
                b= a%2;

            if (b==1)
            {
                Console.WriteLine("Seu numero e impar");
            }

            else
            {
                Console.WriteLine("Seu numero e par");
            }
                Console.ReadKey();
            }
        }     
    } 
} 