using System;
using System.Collections.Generic;

namespace Par_e_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeiro passo
            //Receber um número setado pelo usuário na tela
            int valorInteiro = EscreverEConverter();
            
            Console.WriteLine("==========================");

            //Segundo passo
            //Pegar os próximos 100 números depois do número escolhido e guardar num array
            List<int> listaInteiro = AddValorListaInteiro(valorInteiro);

            //Terceiro passo
            //Printar na tela todos os números ímpares do array
            PrintarNumerosImparesNaTela(listaInteiro);
            
            Console.WriteLine("Fim");
        }
        static int EscreverEConverter()
        {
            Console.WriteLine("Escreva um número:");
            string valor = Console.ReadLine();                
            int valorInteiro = Convert.ToInt32(valor);
            return valorInteiro;
        }
        static List<int> AddValorListaInteiro(int valorInteiro)
        {
            List<int> temp = new List<int>();

            for(int contador=0;contador<100;contador++)
            {
                valorInteiro++;
                temp.Add(valorInteiro);
            }
            return temp;
        }
        static void PrintarNumerosImparesNaTela(List<int> listaInteiro)
        {
            for (int contador1 = 0; contador1 < listaInteiro.Count; contador1++)
            {
                int n = listaInteiro[contador1];
                bool eUmNumeroImpar = EUmNumeroImpar(n);
                
                if(eUmNumeroImpar){
                    Console.WriteLine(n);
                }
            }

        }
        static bool EUmNumeroImpar(int numero)
        {
            return numero%2==1;
        }
    } 
}      