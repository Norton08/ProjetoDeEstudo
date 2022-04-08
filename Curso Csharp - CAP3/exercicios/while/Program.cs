using System;

namespace Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            System.Console.WriteLine("Digite a senha de 4 digitos:");
            int n = int.Parse(Console.ReadLine());

            while( n != 2002){

                System.Console.WriteLine("Senha inválida!");
                System.Console.WriteLine("Digite a senha novamente:");
                n = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Acesso permitido");

            //exercicio 2
            int x, y;
            System.Console.WriteLine("Infome um x:");
            x = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe um y");
            y = int.Parse(Console.ReadLine());

            while( x !=0 && y!=0 ) {

                if( x>0 && y>0 ){
                    System.Console.WriteLine("primeiro");
                }
                else if  ( x> 0 && y<0 ){
                    System.Console.WriteLine("segundo");
                }
                else if ( x<0 && y <0  ){
                    System.Console.WriteLine("terceiro");
                }
                else{
                    System.Console.WriteLine("quarto");
                }
                System.Console.WriteLine("Informe outro x:");
                x = int.Parse(Console.ReadLine());
                System.Console.WriteLine("E informe outro y:");
                y = int.Parse(Console.ReadLine());
            }
            
            //exercicio 3
            System.Console.WriteLine("Olá! Escolha qual combustível você tem preferência");
            System.Console.WriteLine("1.Alcool");
            System.Console.WriteLine("2.Gasolina");
            System.Console.WriteLine("3.Diesel");
            System.Console.WriteLine("4.Ir embora e fim de serviço");
            int a, g, d ;
            a = g = d = 0;
            int c = int.Parse(Console.ReadLine());
            while( c != 4 ){

                if( c == 1 ){
                    a++;
                }
                else if ( c == 2 ){
                    g++;
                }
                else if( c == 3 ){
                    d++;
                }
                else if (c > 4 || c < 0){
                    System.Console.WriteLine("Olá! Escolha qual combustível você tem preferência");
                    c = int.Parse(Console.ReadLine());
                }

                System.Console.WriteLine("Olá! Escolha qual combustível você tem preferência");
                c = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("========================");
            System.Console.WriteLine("Muito Obrigado!!");
            System.Console.WriteLine("1.Alcool: " + a);
            System.Console.WriteLine("2.Gasolina: " + g);
            System.Console.WriteLine("3.Diesel: " + d);
        }
    }
}
