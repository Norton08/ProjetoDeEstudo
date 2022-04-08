using System;
using System.Collections.Generic;
using _15.Entidades;

namespace _15
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int minhaOpcaoEscolhida = 0;

            while(minhaOpcaoEscolhida != 9) {
                TelaInicial();

                minhaOpcaoEscolhida = int.Parse(Console.ReadLine());

                Console.Clear();

                Rotas(minhaOpcaoEscolhida);

                if (minhaOpcaoEscolhida != 9){
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
    
        static void TelaInicial() {
            Console.WriteLine("============================================");
            Console.WriteLine("================ Programa ==================");
            Console.WriteLine("============================================");
            
            Console.WriteLine("Opção 1 - Mostrar tela de cadastro de usuarios");
            Console.WriteLine("Opção 2 - Mostrar tela de cadastro de enderecos");
            Console.WriteLine("Opção 3 - Mostrar tela bonitona");
            Console.WriteLine("Opção 9 - Pressione para sair");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Minha opção é: ");
        }

        static void Rotas(int minhaRota) {
            switch(minhaRota) {
                case 1:
                    TelaCadastroDeUsuarios();
                    break;
                case 2:
                    TelaCadastroEnderecos();
                    break;
                case 3:
                    TelaBonitona();
                    break;
                case 9:
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        static void TelaCadastroDeUsuarios() {
            Console.WriteLine("============================================");
            Console.WriteLine("========== Cadastro de usuários ============");
            Console.WriteLine("============================================");

            Console.Write("Nome: Jão Apolinario");
            Console.Write("         ");
            Console.Write("Idade: 35");
            Console.WriteLine("");

            Console.Write("Sexo: Trans");
            Console.Write("         ");
            Console.WriteLine("Estado civil: Solteiro");
            Console.WriteLine("--------------------------------------------");

        }

        static void TelaCadastroEnderecos() {
            Console.WriteLine("============================================");
            Console.WriteLine("========== Cadastro de Endereços ===========");
            Console.WriteLine("============================================");

            Console.Write("Rua: Rua tapajos");
            Console.Write("         ");
            Console.Write("Complemento: qd 35 lt 18");
            Console.WriteLine("");

            Console.Write("Cep: 74518-788");
            Console.WriteLine("Ponto Referencia: Em frente casa de aborto feto feliz");
            Console.WriteLine("--------------------------------------------");
        }

        static void TelaBonitona() {
            Console.WriteLine("============================================");
            Console.WriteLine("============== Tela Bonitona ===============");
            Console.WriteLine("============================================");
            Console.Write("Caralho");
            Console.Write("Como vc é bonitão");
            Console.Write("Você é bonitão mesmo");
            Console.Write("Vem comer meu cú");
            Console.Write("Eu adoro");
            Console.Write("Vamos!!!");
            Console.WriteLine("--------------------------------------------");

        }
    }
}
