using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            Pote meuPote = new Pote(30, 45, Formato.Cilindrico);

            meuPote.AbrirPote();

            meuPote.FecharPote();

            var i = meuPote.PesoMaximoConteudo;

            var meuSegundoPorte = new Pote(28, 75, Formato.Quadrado);

            meuSegundoPorte.Altura = 25;
            meuSegundoPorte.Largura = 70;
            meuSegundoPorte.Formato = Formato.Quadrado;
        }
    }
}
