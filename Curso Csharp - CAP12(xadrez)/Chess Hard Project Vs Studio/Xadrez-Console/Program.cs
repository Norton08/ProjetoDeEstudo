﻿using tabuleiro;
using Xadrez;
using tabuleiro.Exceptions;
using System;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        System.Console.WriteLine();
                        System.Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        System.Console.WriteLine();
                        System.Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);
                        
                        partida.RealizaJogada(origem, destino);

                    }
                    catch(TabuleiroException e)
                    {
                        System.Console.WriteLine(e.Message);
                        System.Console.ReadLine();
                    }
                    Console.Clear();
                    Tela.ImprimirPartida(partida);                        
                }
            }   
            catch(TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            } 

        }
    }
}
