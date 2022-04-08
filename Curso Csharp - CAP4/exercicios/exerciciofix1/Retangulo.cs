using System;

namespace exerciciofix1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area(){
            return Altura * Largura;
        }
        public double Perimetro(){
            return 2*(Altura + Largura);
        }
        public double Diagonal(){
            return Math.Sqrt(Altura*Altura + Largura*Largura);
        }




    }



}