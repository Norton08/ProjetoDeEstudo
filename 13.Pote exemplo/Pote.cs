using System;

namespace _13
{
    public class Pote
    {
        public Pote(int altura, int largura, Formato formato) {
            Altura = altura;
            Largura = largura;
            Formato = formato;
        }

        public int Altura {get; set;}
        public int Largura {get; set;}
        public Formato Formato {get; set;}
        public decimal PesoMaximoConteudo 
        { 
            get
            {
                if (Formato == Formato.Cilindrico)
                {
                    return (Altura * Largura) * 2 -1;
                }
                else {
                    return (Altura * Largura) * 3;
                }
            } 
        }
        public Tampa Tampa {get;set;}
        public bool Aberto {get; private set;} = false;

        public void AbrirPote() {
            Tampa.Girar();
            Aberto = true;
        }

        public void FecharPote() {
            Tampa.Girar();
            Aberto = false;
        }
    }

    public enum Formato {
        Cilindrico,
        Quadrado,
    }
}
