using System;

namespace _5.Dois_Números_operação
{
    class Program
    {
        enum Operacao 
        {
            Soma=1,
            Subtração,
            Multiplicação,
            Divisão
        }

        static void Main(string[] args)
        {
            //Exercicio 3-
            Math();
        }

        static void Math ()
        {
            Console.WriteLine("Coloque um número");

            float numb1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Coloque outro número");

            float numb2= float.Parse(Console.ReadLine());

            Console.Write(numb1);

            Console.Write(" e " );

            Console.WriteLine(numb2);

            Console.WriteLine("Escolha uma operação matemática");

            Console.WriteLine("1-Soma/n2-Subtração/n3-Multiplicação/n4-Divisão");

            int index= int.Parse(Console.ReadLine());

            Operacao opcaoSelecionada = (Operacao)index;

            if(numb2==0)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {  
            switch (opcaoSelecionada)
            {
                case Operacao.Soma:
                    Console.WriteLine(numb1+numb2);
                    break;       

                case Operacao.Subtração:
                    Console.WriteLine(numb1-numb2);
                    break;

                case Operacao.Multiplicação:
                    Console.WriteLine(numb1*numb2);
                    break;       
                    //Validar divisão por zero
                    //Se o número 2 for 0, mostrar na tela "Não é possível dividir por zero"
                
                case Operacao.Divisão:
                    Console.WriteLine(numb1/numb2);
                    break;
            }     
            }    
        }
    }  
}