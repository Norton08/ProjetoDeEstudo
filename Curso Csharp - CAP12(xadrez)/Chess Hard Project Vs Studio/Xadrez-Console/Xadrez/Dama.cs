using tabuleiro;

namespace Xadrez
{
    class Dama : Peca
    {
        public Dama(Cor cor,Tabuleiro tab):base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "D";
        }
        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            // N
           pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
           while (Tab.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.Linha, pos.Coluna] = true;
               if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
               {
                   break;
               }
               pos.Linha = pos.Linha - 1;
           }

            // S
           pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
           while (Tab.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.Linha, pos.Coluna] = true;
               if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
               {
                   break;
               }
               pos.Linha = pos.Linha + 1;
           }

            // E
           pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1 );
           while (Tab.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.Linha, pos.Coluna] = true;
               if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
               {
                   break;
               }
               pos.Coluna = pos.Coluna + 1;
           }
          
            // W
           pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1 );
           while (Tab.PosicaoValida(pos) && PodeMover(pos))
           {
               mat[pos.Linha, pos.Coluna] = true;
               if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
               {
                   break;
               }
               pos.Coluna = pos.Coluna - 1;
           }
            //NW
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //NE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            } 
            //SE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
            }                 
            //SW
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }     
            
            return mat; 
        }                       

    }
}