using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _14._Métodos_para_Três_números
{
    class Program
    {
        enum Acao
        {
            Decrescentes=1, 
            NumeroMax, 
            PrimeiroMaiorQueASomaDosOutrosDois
        }

        static void Main(string[] args)
        {
           var listaNumeros= PecaParaOUsuarioInformarTresNumeros();
           Console.WriteLine("1-Decrescentes/n2-Maior valor/n3-Primeiro valor maior que a soma dos outros dois valores");

            int index= int.Parse(Console.ReadLine());

            Acao opcaoSelecionada = (Acao)index;

            Console.WriteLine("================");

            switch (opcaoSelecionada)
            {
                case Acao.Decrescentes:
                    Console.WriteLine("Aqui está os números em ordem decrescente:");
                    Decrescentes(listaNumeros);
                    break;
                case Acao.NumeroMax:
                    MaiorValor(listaNumeros);
                    break;
                case Acao.PrimeiroMaiorQueASomaDosOutrosDois:
                    PrimeiroMaiorQueASomaDosOutrosDois(listaNumeros);
                    break;
            }
        }
        
        static List<decimal> PecaParaOUsuarioInformarTresNumeros()
        {
            Console.WriteLine("Escreva 3 Números");
            List<decimal> listaNumeros= new List<decimal>();

            Console.WriteLine("Primeiro valor:");
            decimal numb1= decimal.Parse(Console.ReadLine());
            listaNumeros.Add(numb1);

            Console.WriteLine("Segundo valor:");
            decimal numb2= decimal.Parse(Console.ReadLine());
            listaNumeros.Add(numb2);

            Console.WriteLine("Terceiro valor:");
            decimal numb3= decimal.Parse(Console.ReadLine());
            listaNumeros.Add(numb3);

            return listaNumeros;
        } 
        
        static void Decrescentes(List<decimal> listaNumeros)
        {
            listaNumeros=listaNumeros.OrderByDescending(n=>n).ToList();
           
            foreach (int numerosdecrescentes in listaNumeros)
            {   
                Console.WriteLine(numerosdecrescentes + " ");
            }
        }
        static void MaiorValor (List<decimal> listaNumeros)
        {
            listaNumeros=listaNumeros.OrderByDescending(n=>n).ToList();

            decimal numbmax= listaNumeros[0];

            Console.WriteLine("O maior valor é "+ numbmax);

        }
        static void PrimeiroMaiorQueASomaDosOutrosDois(List<decimal> listaNumeros)
        {
            if (listaNumeros[0] > listaNumeros[1] +listaNumeros[2])
            {
                Console.WriteLine("O Primeiro numero é maior que a soma dos outros dois");
            }    
            else
            {
                Console.WriteLine("O Primeiro numero é menor que a soma dos outros dois");
            }
        }
    }
}
