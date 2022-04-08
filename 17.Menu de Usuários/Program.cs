using System;
using System.Collections.Generic;
using System.Globalization;


namespace _17.Menu_de_Usuários
{
    class Program
    {
        static List<Pessoa> Lista {get;set;}

        static void Main(string[] args)
        {
            
            Lista = new List<Pessoa>();

            Console.Clear();

            int opcaoEscolhida = 0;

            while ( opcaoEscolhida != 3 )
            {

                TelaInicial();

                opcaoEscolhida = int.Parse(Console.ReadLine()); 

                Console.Clear();

                Rotas(opcaoEscolhida);

                if (opcaoEscolhida != 3)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        static void TelaInicial()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("===============================");
            Console.WriteLine("====== Escolha uma opcao ======");
            Console.WriteLine("===============================");
            Console.WriteLine("===============================");


            Console.WriteLine("Opcao 1 - Cadastrar um usuario ");
            Console.WriteLine("Opcao 2 - Listar os usuarios cadastrados ");
            Console.WriteLine("Opcao 3 - Sair ");
            Console.WriteLine("===============================");
            Console.WriteLine("Sua opcao é:");
        }

        static void Rotas(int minhaRota)
        {
            switch (minhaRota)
            {
                case 1:
                TeladeCadastrodeUsuarios();
                break;
                case 2:
                ListarUsuarios();
                break;
                case 3:
                break;
                default:
                Console.WriteLine("Opcao inválida");
                break;
            }
            
        }

        static void TeladeCadastrodeUsuarios()
        {
        
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            Console.WriteLine("========== Cadastro de usuários ============");
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");

            Console.WriteLine("Nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());

            Lista.Add(new Pessoa(nome, idade));

        }

        static void ListarUsuarios()
        {

            Console.WriteLine("============================================");
            Console.WriteLine("============================================");   
            Console.WriteLine("====== Lista de usuários cadastrados =======");
            Console.WriteLine("============================================");
            Console.WriteLine("============================================");
            
            foreach (Pessoa p in Lista)
            {

                Console.WriteLine("Nome: " + p.Nome + "                     " + "Idade: " + p.Idade);

            }
        }
    }
}
